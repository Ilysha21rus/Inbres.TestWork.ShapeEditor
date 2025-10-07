using SteamWorkshopExplorer.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SteamWorkshopExplorer.ViewModels
{
    public partial class EllipseViewModel : ObservableObject
    {
        [ObservableProperty] private double width;
        [ObservableProperty] private double height;
        [ObservableProperty] private double x;
        [ObservableProperty] private double y;
    }
}