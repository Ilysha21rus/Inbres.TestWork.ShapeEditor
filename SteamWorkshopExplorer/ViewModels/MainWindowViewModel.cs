using Avalonia;
using SteamWorkshopExplorer.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SteamWorkshopExplorer.ViewModels;
{ 
    public class MainWindowModel
    {
        public ObservableCollection<ShapeModel> Shapes { get; set; } = new();
        
        public ICommand AddBezierCommand { get; }
        public ICommand AddEllipseCommand { get; }
        public ICommand ClearCommand { get; }
        
