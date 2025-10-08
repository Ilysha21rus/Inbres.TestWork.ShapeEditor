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

        private void AddEllipse_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AddBezier_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void Delete_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}