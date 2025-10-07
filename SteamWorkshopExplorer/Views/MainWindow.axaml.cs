using Avalonia.Controls;
using Avalonia.Input;
using Avalonia;
using SteamWorkshopExplorer.ViewModels;

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
            vm.AddEllipseCommand.Execute(point);
        }
    }
}