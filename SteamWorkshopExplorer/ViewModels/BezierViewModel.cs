using Avalonia;

namespace SteamWorkshopExplorer.ViewModels
{
    public class BezierViewModel : ViewModelBase
    {
        private Point _start;
        public Point Start { get => _start; set => RaiseAndSetIfChanged(ref _start, value); }

        private Point _control1;
        public Point Control1 { get => _control1; set => RaiseAndSetIfChanged(ref _control1, value); }

        private Point _control2;
        public Point Control2 { get => _control2; set => RaiseAndSetIfChanged(ref _control2, value); }

        private Point _end;
        public Point End { get => _end; set => RaiseAndSetIfChanged(ref _end, value); }
    }
}