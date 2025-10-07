using Avalonia;
using System.Collections.Generic;
namespace SteamWorkshopExplorer.Models
{
    public class BezierModel : ShapeModel
    {
        private Avalonia.Collections.AvaloniaList<Point> _controlPoints = new();

        public Avalonia.Collections.AvaloniaList<Point> ControlPoints
        {
            get => _controlPoints;
            set { _controlPoints = value; OnPropertyChanged(nameof(ControlPoints)); }
        }
    }
}