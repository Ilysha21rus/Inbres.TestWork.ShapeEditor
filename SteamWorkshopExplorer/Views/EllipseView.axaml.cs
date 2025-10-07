using Avalonia.Controls;
using Avalonia.Input;
using SteamWorkshopExplorer.ViewModels;
using Avalonia;

namespace SteamWorkshopExplorer.Views;

public partial class EllipseView : UserControl
{
    private bool _isDragging;
    private Point _dragStart;
    private double _startX;
    private double _startY;

    public EllipseView()
    {
        InitializeComponent();
    }

    private EllipseViewModel VM => DataContext as EllipseViewModel;

    private void Ellipse_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (VM == null) return;

        _isDragging = true;
        _dragStart = e.GetPosition(this.Parent as Canvas);
        _startX = VM.X;
        _startY = VM.Y;

        // захват указателя для drag’n’drop
        e.Pointer.Capture(sender as IInputElement);
    }

    private void Ellipse_PointerMoved(object? sender, PointerEventArgs e)
    {
        if (_isDragging && VM != null)
        {
            var pos = e.GetPosition(this.Parent as Canvas);
            VM.X = _startX + (pos.X - _dragStart.X);
            VM.Y = _startY + (pos.Y - _dragStart.Y);
        }
    }

    private void Ellipse_PointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        _isDragging = false;
        e.Pointer.Capture(null); // отпустить указатель
    }
}