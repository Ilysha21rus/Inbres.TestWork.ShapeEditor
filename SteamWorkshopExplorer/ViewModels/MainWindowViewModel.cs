using Avalonia;
using SteamWorkshopExplorer.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace SteamWorkshopExplorer.ViewModels;
{ 
    public class MainWindowModel
    {
        public ObservableCollection<ShapeModel> Shapes { get; set; } = new();
        
        public ICommand AddBezierCommand { get; }
        public ICommand AddEllipseCommand { get; }
        public ICommand ClearCommand { get; }

        public MainViewModel()
        {
            AddEllipseCommand = new RelayCommand(_ => AddEllipse(50, 50));
            AddBezierCommand = new RelayCommand(_ =>
            {
                AddBezier(
                    new Point(50, 200),
                    new Point(150, 100),
                    new Point(250, 100),
                    new Point(350, 200)
                );
            });

            ClearCommand = new RelayCommand(_ => Shapes.Clear());
        }