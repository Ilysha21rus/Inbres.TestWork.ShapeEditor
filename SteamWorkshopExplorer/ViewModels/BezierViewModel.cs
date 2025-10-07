using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
using SteamWorkshopExplorer.Models;

namespace SteamWorkshopExplorer.ViewModels;

public partial class BezierViewModel : ObservableObject
{
    [ObservableProperty]
    private BezierModel bezier = new();
}