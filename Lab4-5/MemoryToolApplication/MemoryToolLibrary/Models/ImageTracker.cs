using System.Windows.Media.Imaging;
using System.Windows;

namespace MemoryToolLibrary.Managers
{
    public class ImageTracker : DependencyObject
    {
        public static readonly DependencyProperty CheckedProperty = DependencyProperty.Register("Checked", typeof(bool), typeof(ImageTracker), new PropertyMetadata(false));

        public bool Checked
        {
            get => (bool)GetValue(CheckedProperty);
            set => SetValue(CheckedProperty, value);
        }

        public BitmapImage Image { get; private set; }

        public ImageTracker(BitmapImage image)
        {
            Image = image;
        }
    }
}
