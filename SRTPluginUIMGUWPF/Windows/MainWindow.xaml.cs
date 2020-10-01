using SRTPluginProviderMGU;
using SRTPluginUIMGUWPF.Models;
using SRTPluginUIMGUWPF.Utilities;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace SRTPluginUIMGUWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IGameMemoryMGU _gameMemory;
        private OptionModel _options;

        private IntPtr _windowEventHook;
        private GCHandle _windowEventGCHandle;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = Plugin.Models.AppView;
            _gameMemory = Plugin.Models.AppView.GameMemory;
            _options = Plugin.Models.AppView.Options;

            _options.PropertyChanged += Options_PropertyChanged;

            ToggleAttachWindow();
        }

        private void Options_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "AttachToWindow")
                ToggleAttachWindow();
        }

        private void OptionsMenuItem_Click(object sender, RoutedEventArgs e) =>
            Plugin.Windows.Options.Show();

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e) =>
            Plugin.Windows.About.Show();

        private void MinimizeMenuItem_Click(object sender, RoutedEventArgs e) =>
            WindowState = WindowState.Minimized;

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e) =>
            Close();

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e) =>
            Close();

        private void Window_LocationChanged(object sender, EventArgs e) =>
            Properties.Settings.Default.Save();

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            DisableAttactWindow();
            if (Plugin.IsExiting) return;
            Plugin.Exit();
        }

        protected void AttactToWindow(IntPtr hWnd)
        {
            Utilities.Rect rect = WinEventHook.GetWindowRect(hWnd);

            Top = rect.Top;
            Left = rect.Left - Width;
        }

        protected void ToggleAttachWindow()
        {
            if (_options.AttachToWindow)
            {
                AttactToWindow(_gameMemory.Process.WindowHandle);
                EnableAttactWindow();
            }
            else
                DisableAttactWindow();
        }

        protected void EnableAttactWindow()
        {
            if (_windowEventHook != IntPtr.Zero)
                return;

            try
            {
                Dispatcher.CurrentDispatcher.Invoke(delegate
                {
                    WinEventHook.WinEventDelegate windowEventDelegate = new WinEventHook.WinEventDelegate(AttachWindowEventCallback);
                    _windowEventGCHandle = GCHandle.Alloc(windowEventDelegate);
                    _windowEventHook = WinEventHook.WinEventHookOne(WinEventHook.SWEH_Events.EVENT_OBJECT_LOCATIONCHANGE,
                                                            windowEventDelegate,
                                                            (uint)_gameMemory.Process.Id,
                                                            WinEventHook.GetWindowThread(_gameMemory.Process.WindowHandle));
                });
            }
            catch (Exception ex)
            {
                Plugin.ShowExceptionMessage(ex);
            }

            if (_windowEventHook == IntPtr.Zero)
                DisableAttactWindow();
        }

        protected void DisableAttactWindow()
        {
            try
            {
                if (_windowEventGCHandle.IsAllocated)
                    _windowEventGCHandle.Free();

                if (_windowEventHook != IntPtr.Zero)
                    WinEventHook.WinEventUnhook(_windowEventHook);
            }
            catch (Exception ex)
            {
                Plugin.ShowExceptionMessage(ex);
            }
            finally
            {
                _windowEventHook = IntPtr.Zero;
            }
        }

        protected void AttachWindowEventCallback(IntPtr hWinEventHook,
                           WinEventHook.SWEH_Events eventType,
                           IntPtr hWnd,
                           WinEventHook.SWEH_ObjectId idObject,
                           long idChild,
                           uint dwEventThread,
                           uint dwmsEventTime)
        {
            if (hWnd == _gameMemory.Process.WindowHandle &&
                eventType == WinEventHook.SWEH_Events.EVENT_OBJECT_LOCATIONCHANGE &&
                idObject == WinEventHook.SWEH_ObjectId.OBJID_WINDOW)
                AttactToWindow(hWnd);
        }
    }
}