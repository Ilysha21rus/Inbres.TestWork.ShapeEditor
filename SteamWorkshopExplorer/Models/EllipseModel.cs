using CommunityToolkit.Mvvm.ComponentModel;

namespace SteamWorkshopExplorer.ViewModels;
public class EllipseModel
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; } = 120;
    public double Height { get; set; } = 100;
}