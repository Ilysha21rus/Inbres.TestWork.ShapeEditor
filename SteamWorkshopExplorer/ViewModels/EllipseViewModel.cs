using SteamWorkshopExplorer.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SteamWorkshopExplorer.ViewModels
{
    public partial class EllipseViewModel : ObservableObject
    {
        [ObservableProperty] private double width = 120;
        [ObservableProperty] private double height = 100;
        [ObservableProperty] private double x = 80;
        [ObservableProperty] private double y = 80;
    }
}