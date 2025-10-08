using ReactiveUI;
using System.Collections.ObjectModel;
using SteamWorkshopExplorer.ViewModels;
using System.Reactive;

namespace SteamWorkshopExplorer.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public ObservableCollection<EllipseViewModel> Ellipses { get; } = new();
        public ObservableCollection<BezierViewModel> Beziers { get; } = new();
        
        public ReactiveCommand<Unit, Unit> AddEllipseCommand { get; }
        public ReactiveCommand<Unit, Unit> AddBezierCommand { get; }
        public ReactiveCommand<Unit, Unit> DeleteLastCommand { get; }

        public MainWindowViewModel()
        {
            AddEllipseCommand = ReactiveCommand.Create(AddEllipse);
            AddBezierCommand = ReactiveCommand.Create(AddBezier);
            DeleteLastCommand = ReactiveCommand.Create(DeleteLast);
        }

        private void AddEllipse()
        {
            Ellipses.Add(new EllipseViewModel { X = 50, Y = 50 });
        }

        private void AddBezier()
        {
            Beziers.Add(new BezierViewModel
            {
                Start = new Avalonia.Point(10, 10),
                Control1 = new Avalonia.Point(50, 100),
                Control2 = new Avalonia.Point(150, 100),
                End = new Avalonia.Point(200, 10)
            });
        }

        private void DeleteLast()
        {
            if (Ellipses.Count > 0)
                Ellipses.RemoveAt(Ellipses.Count - 1);
            else if (Beziers.Count > 0)
                Beziers.RemoveAt(Beziers.Count - 1);
        }
    }
}