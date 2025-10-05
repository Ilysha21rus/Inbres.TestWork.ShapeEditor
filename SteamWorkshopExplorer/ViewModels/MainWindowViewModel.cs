using Avalonia;
using SteamWorkshopExplorer.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace SteamWorkshopExplorer.ViewModels;
{
    public class MainWindowViewModel
    {
        public ObservableCollection<ShapeModel> Shapes { get; set; } = new();

        public ICommand AddBezierCommand { get; }
        public ICommand AddEllipseCommand { get; }
        public ICommand ClearCommand { get; }

        public MainWindowViewModel()
        {
            AddEllipseCommand = new RelayCommand(_ => AddEllipse(50, 50));
            AddBezierCommand = new RelayCommand(_ =>
            {
                AddBezier(
                    new Point(50, 200),
                    new Point(150, 100),
                    new Point(250, 100),
                    new Point(350, 200)
                );
            });

            ClearCommand = new RelayCommand(_ => Shapes.Clear());
        }

        public void AddEllipse(double x, double y)
        {
            Shapes.Add(new EllipseModel { X = x, Y = y });
        }

        public void AddBezier(params Point[] points)
        {
            var bez = new BezierModel();
            foreach (var point in points) bez.ControlPoints.Add(point);
            Shapes.Add(bez);
        }
    }
}
