using SteamWorkshopExplorer.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SteamWorkshopExplorer.ViewModels;

public partial class BezierViewModel : ObservableObject

{
        public BezierModel Model { get; }

        public BezierViewModel(BezierModel model)
        {
            Model = model;
        }
}