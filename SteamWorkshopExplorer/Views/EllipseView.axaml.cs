using Avalonia.Controls;
using Avalonia.Input;
using SteamWorkshopExplorer.ViewModels;

namespace SteamWorkshopExplorer.Views
{
    public partial class EllipseView : UserControl
    {
        private Avalonia.Point _start;
        private bool _isDragging;

        private Avalonia.Point _resizeStart;
        private double _startWidth, _startHeight;
        private bool _isResizing;

        public EllipseView()
        {
            InitializeComponent();
        }

        private void OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            if (DataContext is EllipseViewModel vm)
            {
                _start = e.GetPosition((Control)sender!);
                _isDragging = true;
                e.Pointer.Capture(sender as IInputElement);
            }
        }

        private void OnPointerMoved(object? sender, PointerEventArgs e)
        {
            if (DataContext is not EllipseViewModel vm)
                return;

            var pos = e.GetPosition((Control)sender!);

            if (_isDragging)
            {
                var dx = pos.X - _start.X;
                var dy = pos.Y - _start.Y;

                vm.X += dx;
                vm.Y += dy;

                _start = pos;
            }
            else if (_isResizing)
            {
                var dx = pos.X - _resizeStart.X;
                var dy = pos.Y - _resizeStart.Y;

                vm.Width = _startWidth + dx;
                vm.Height = _startHeight + dy;
            }
        }

        private void OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            _isDragging = false;
            _isResizing = false;
            e.Pointer.Capture(null);

        }

        private void OnResizePressed(object? sender, PointerPressedEventArgs e)
        {
            if (DataContext is EllipseViewModel vm)
            {
                _resizeStart = e.GetPosition((Control)sender!);
                _startWidth = vm.Width;
                _startHeight = vm.Height;
                _isResizing = true;
                e.Pointer.Capture(sender as IInputElement);
            }
        }

        private void OnResizeMoved(object? sender, PointerEventArgs e)
        {
            if (DataContext is not EllipseViewModel vm || !_isResizing)
                return;

            var pos = e.GetPosition((Control)sender!);
            var dx = pos.X - _resizeStart.X;
            var dy = pos.Y - _resizeStart.Y;

            vm.Width = _startWidth + dx;
            vm.Height = _startHeight + dy;
        }

        private void OnResizeReleased(object? sender, PointerReleasedEventArgs e)
        {
            _isResizing = false;
            e.Pointer.Capture(null);

        }
    }
}