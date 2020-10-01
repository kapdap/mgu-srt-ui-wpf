using SRTPluginUIMGUWPF.Utilities;
using System.Windows;
using System.Windows.Input;

namespace SRTPluginUIMGUWPF
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            DataContext = Plugin.Models.AppView;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Plugin.IsExiting) return;

            Visibility = Visibility.Hidden;
            e.Cancel = true;
        }

        private void UserInterfaceLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://kapdap.github.io/mgu-srt/");

        private void UserInterfaceGitLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://github.com/kapdap/mgu-srt-ui-wpf");

        private void MemoryProviderLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://kapdap.github.io/mgu-srt/");

        private void MemoryProviderGitLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://github.com/kapdap/mgu-srt-provider");

        private void PluginHostLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://www.neonblu.com/SRT/");

        private void PluginHostGitLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://github.com/Squirrelies/SRTHost");

        private void WebsiteLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://kapdap.github.io/mgu-cvx-srt/");

        private void GitHubLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://github.com/kapdap/mgu-srt-ui-wpf");

        private void LicenseLink_MouseUp(object sender, MouseButtonEventArgs e) =>
            URLHelper.OpenURL("https://github.com/kapdap/mgu-srt-ui-wpf/blob/master/LICENSE");
    }
}