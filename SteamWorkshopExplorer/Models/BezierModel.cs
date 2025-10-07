using Avalonia;
using System.Collections.ObjectModel;
using Avalonia.Collections;

namespace SteamWorkshopExplorer.Models
{
    public class BezierModel : ShapeModel
    {
        public AvaloniaList<Point> ControlPoints { get; set; } = new AvaloniaList<Point>();
    }
}