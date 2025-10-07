﻿using Avalonia;
using SteamWorkshopExplorer.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SteamWorkshopExplorer.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<ShapeModel> Shapes { get; } = new();

        [RelayCommand]
        private void AddEllipse()
        {
            Shapes.Add(new EllipseModel { X = 100, Y = 100 });
        }

        [RelayCommand]
        private void AddBezier()
        {
            var bez = new BezierModel();
            bez.ControlPoints.Add(new Point(50, 200));
            bez.ControlPoints.Add(new Point(150, 100));
            bez.ControlPoints.Add(new Point(250, 100));
            bez.ControlPoints.Add(new Point(350, 200));
            Shapes.Add(bez);
        }

        [RelayCommand]
        private void Clear()
        {
            Shapes.Clear();
        }
    }
}