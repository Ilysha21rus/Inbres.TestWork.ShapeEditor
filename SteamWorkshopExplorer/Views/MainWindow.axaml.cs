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
            VM.AddEllipse(50, 50); 
        }

        private void AddBezier_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            VM.AddBezier(new Point(100, 100),
                new Point(150, 50),
                new Point(250, 150),
                new Point(300, 100));
        }

        private void Delete_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            VM.DeleteLast();
        }
    }
}