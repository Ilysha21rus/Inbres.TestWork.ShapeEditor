using Avalonia;

namespace SteamWorkshopExplorer.Models
{
    public class EllipseModel : ShapeModel
    {
        private double _x, _y, _width, _height;

        public double X { get => _x; set { _x = value; OnPropertyChanged(nameof(X)); } }
        public double Y { get => _y; set { _y = value; OnPropertyChanged(nameof(Y)); } }
        public double Width { get => _width; set { _width = value; OnPropertyChanged(nameof(Width)); } }
        public double Height { get => _height; set { _height = value; OnPropertyChanged(nameof(Height)); } }
    }
}