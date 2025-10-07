using SteamWorkshopExplorer.Models;

namespace SteamWorkshopExplorer.ViewModels
{
    public class BezierViewModel
    {
        public BezierModel Model { get; }

        public BezierViewModel(BezierModel model)
        {
            Model = model;
        }
    }
}