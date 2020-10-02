using SRTPluginProviderMGU.Models;
using System;
using System.Windows.Media;

namespace SRTPluginUIMGUWPF
{
    public class PluginConfig : BaseNotifyModel
    {
        private bool _alwaysOnTop = false;
        public bool AlwaysOnTop
        {
            get => _alwaysOnTop;
            set => SetField(ref _alwaysOnTop, value);
        }

        private bool _attachToWindow = false;
        public bool AttachToWindow
        {
            get => _attachToWindow;
            set => SetField(ref _attachToWindow, value);
        }

        private Color _background = Color.FromArgb(255, 0, 0, 0);
        public Color Background
        {
            get => _background;
            set => SetField(ref _background, value);
        }

        private bool _transparent = false;
        public bool Transparent
        {
            get => _transparent;
            set => SetField(ref _transparent, value);
        }

        private double _opacity = 1d;
        public double Opacity
        {
            get
            {
                SetField(ref _opacity, GetRange(_opacity, 0.05, 1d, 2));
                return _opacity;
            }
            set => SetField(ref _opacity, GetRange(value, 0.05, 1d, 2));
        }

        private double _charactersScale = 1d;
        public double CharactersScale
        {
            get
            {
                SetField(ref _charactersScale, GetRange(_charactersScale, 0.5, 2d, 2));
                return _charactersScale;
            }
            set => SetField(ref _charactersScale, GetRange(value, 0.5, 2d, 2));
        }

        private double _textScale = 1d;
        public double TextScale
        {
            get
            {
                SetField(ref _textScale, GetRange(_textScale, 0.5, 2d, 2));
                return _textScale;
            }
            set => SetField(ref _textScale, GetRange(value, 0.5, 2d, 2));
        }

        private double _enemyScale = 1d;
        public double EnemyScale
        {
            get
            {
                SetField(ref _enemyScale, GetRange(_enemyScale, 0.5, 2d, 2));
                return _enemyScale;
            }
            set => SetField(ref _enemyScale, GetRange(value, 0.5, 2d, 2));
        }

        private bool _showTitlebar = false;
        public bool ShowTitlebar
        {
            get => _showTitlebar;
            set => SetField(ref _showTitlebar, value);
        }

        private bool _showTimer = true;
        public bool ShowTimer
        {
            get => _showTimer;
            set => SetField(ref _showTimer, value);
        }

        private bool _showStatistics = true;
        public bool ShowStatistics
        {
            get => _showStatistics;
            set => SetField(ref _showStatistics, value);
        }

        private bool _showInventory = true;
        public bool ShowInventory
        {
            get => _showInventory;
            set => SetField(ref _showInventory, value);
        }

        private bool _showEquipment = false;
        public bool ShowEquipment
        {
            get => _showEquipment;
            set => SetField(ref _showEquipment, value);
        }

        private bool _showEnemy = true;
        public bool ShowEnemy
        {
            get => _showEnemy;
            set => SetField(ref _showEnemy, value);
        }

        private bool _debug = false;
        public bool Debug
        {
            get => _debug;
            set => SetField(ref _debug, value);
        }

        private bool _debugCharacters = false;
        public bool DebugCharacters
        {
            get => _debugCharacters;
            set => SetField(ref _debugCharacters, value);
        }

        private bool _debugEnemy = false;
        public bool DebugEnemy
        {
            get => _debugEnemy;
            set => SetField(ref _debugEnemy, value);
        }

        private double GetRange(double value, double min, double max, int? round = null)
        {
            value = Math.Max((double)value, min);
            value = Math.Min((double)value, max);

            if (round != null)
                value = Math.Round((double)value, (int)round);

            return value;
        }
    }
}