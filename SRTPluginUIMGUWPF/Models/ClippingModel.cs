using SRTPluginProviderMGU.Models;
using System;

namespace SRTPluginUIMGUWPF.Models
{
    public class ClippingModel : BaseNotifyModel
    {
        private int _x;
        public int X
        {
            get => _x;
            set => SetField(ref _x, value, "X", "Clipping");
        }

        private int _y;
        public int Y
        {
            get => _y;
            set => SetField(ref _y, value, "Y", "Clipping");
        }

        private int _width;
        public int Width
        {
            get => _width;
            set => SetField(ref _width, value, "Width", "Clipping");
        }

        private int _height;
        public int Height
        {
            get => _height;
            set => SetField(ref _height, value, "Height", "Clipping");
        }

        public string Clipping =>
            String.Format("{0},{1},{2},{3}", X, Y, Width, Height);

        public void Update(int[] clip)
        {
            _x = clip[0];
            _y = clip[1];
            _width = clip[2];
            _height = clip[3];

            OnPropertyChanged("X");
            OnPropertyChanged("Y");
            OnPropertyChanged("Width");
            OnPropertyChanged("Height");
            OnPropertyChanged("Clipping");
        }
    }
}
