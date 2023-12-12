using MemoryToolApplication.Managers;
using MemoryToolLibrary.MVVM;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MemoryToolApplication.ViewModels
{
    internal class ClickableImageViewModel : BaseViewModel
    {
        public static readonly DependencyProperty InfoTextProperty = DependencyProperty.Register("InfoText", typeof(string), typeof(ClickableImageViewModel), new PropertyMetadata(null));
        public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.Register("IsEnabled", typeof(bool), typeof(ClickableImageViewModel), new PropertyMetadata(true));

        BitmapImage _image;
        double _width;
        double _height;
        bool _isChecked = false;

        public ClickableImageViewModel(BitmapImage image, double width, double height, TestManager manager)
        {
            _image = image;
            _width = width;
            _height = height;
            manager.BindCheck(this);
        }

        public BitmapImage Image => _image;

        public double Width => _width;

        public double Height => _height;

        public double ControlWidth => _width + 30;

        public double ControlHeight => _height + 30;

        public string InfoText
        {
            get => (string)GetValue(InfoTextProperty);
            set => SetValue(InfoTextProperty, value);
        }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        public bool IsEnabled
        {
            get => (bool)GetValue(IsEnabledProperty);
            set => SetValue (IsEnabledProperty, value);
        }

    }
}
