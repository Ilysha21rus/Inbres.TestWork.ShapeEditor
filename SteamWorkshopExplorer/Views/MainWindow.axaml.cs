using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using SteamWorkshopExplorer.ViewModels;

namespace SteamWorkshopExplorer.Views
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel VM => DataContext as MainWindowViewModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        }
    
}