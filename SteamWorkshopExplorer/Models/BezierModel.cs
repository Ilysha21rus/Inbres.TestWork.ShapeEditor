using Avalonia;
using System.Collections.ObjectModel;

namespace SteamWorkshopExplorer.Models
{
    public class BezierModel : ShapeModel
    {
        public ObservableCollection<Point> ControlPoints { get; set; } = new();
    }
}