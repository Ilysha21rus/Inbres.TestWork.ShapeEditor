using Avalonia;
using System.Collections.ObjectModel;

namespace SteamWorkshopExplorer.Models;

public class BezierModel
{
    public ObservableCollection<Point> ControlPoints { get; } = new();
}