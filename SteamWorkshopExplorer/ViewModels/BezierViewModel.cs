using Avalonia;
using ReactiveUI;
using SteamWorkshopExplorer.Models;
using System.Collections.ObjectModel;

namespace SteamWorkshopExplorer.ViewModels
{
    public class BezierViewModel : ReactiveObject
    {
        public BezierModel Model { get; }

        public ObservableCollection<Point> ControlPoints { get; }
        public BezierViewModel(BezierModel model)
        {
            Model = Model;
            ControlPoints = new ObservableCollection<Point>(model.ControlPoints);
        }
    }
}