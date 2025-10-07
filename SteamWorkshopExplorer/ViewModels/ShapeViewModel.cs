using CommunityToolkit.Mvvm.ComponentModel;

namespace SteamWorkshopExplorer.ViewModels
{
    public abstract partial class ShapeViewModel : ObservableObject
    {
        [ObservableProperty] private double x;
        [ObservableProperty] private double y;
    }
}