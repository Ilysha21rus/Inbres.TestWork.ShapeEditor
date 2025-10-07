using Avalonia.Controls;
using Avalonia.Input;
using Avalonia;
using SteamWorkshopExplorer.ViewModels;
using SteamWorkshopExplorer.Views;

namespace SteamWorkshopExplorer.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private void Canvas_PointerPressed(object sender, PointerPressedEventArgs e)
    {
        if (sender is Control control && DataContext is MainWindowViewModel vm)
        {
            var point = e.GetPosition(control);
            vm.AddEllipseAtCommand.Execute(point);
            var ellipseVM = vm.Shapes[^1] as EllipseViewModel;
            if (ellipseVM != null)
            {
                var ellipseView = new EllipseView { DataContext = ellipseVM };
                Canvas.SetLeft(ellipseView, ellipseVM.X);
                Canvas.SetTop(ellipseView, ellipseVM.Y);
                Canvas.Children.Add(ellipseView);
            }
        }
    }
}