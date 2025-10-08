using Avalonia.Controls;
using SteamWorkshopExplorer.ViewModels;

namespace SteamWorkshopExplorer.Views
{
    public partial class EllipseView : UserControl
    {
        public EllipseView()
        {
            InitializeComponent();
        }

        public void SetViewModel(EllipseViewModel vm)
        {
            this.DataContext = vm;
        }
    }
}