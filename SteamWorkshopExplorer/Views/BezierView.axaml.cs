using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using SteamWorkshopExplorer.ViewModels;

namespace SteamWorkshopExplorer.Views
{
    public partial class BezierView : UserControl
    {
        private readonly BezierViewModel viewModel;

        public BezierView()
        {
            InitializeComponent();

            viewModel = new BezierViewModel
            {
                Start = new Point(50, 50),
                Control1 = new Point(100, 0),
                Control2 = new Point(150, 100),
                End = new Point(200, 50)
            };

            DataContext = viewModel;

            DrawBezier();
        }

        private void DrawBezier()
        {
            var path = new Path
            {
                Stroke = Brushes.Blue,
                StrokeThickness = 2
            };

            var geometry = new StreamGeometry();

            using (var ctx = geometry.Open())
            {
                ctx.BeginFigure(viewModel.Start, false);
                
                ctx.BezierTo(viewModel.Control1, viewModel.Control2, viewModel.End, true, false);
            }

            path.Data = geometry;

            RootCanvas.Children.Add(path);
        }
    }
}