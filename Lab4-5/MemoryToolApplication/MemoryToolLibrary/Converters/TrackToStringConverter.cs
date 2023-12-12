using MemoryToolLibrary.Managers;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MemoryToolLibrary.Converters
{
    public class TrackToStringConverter : IValueConverter
    {
        readonly Func<BitmapImage, bool> _checker;

        public TrackToStringConverter(Func<BitmapImage, bool> checker)
        {
            _checker = checker;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool flag && parameter is ImageTracker track)
            {
                if (flag)
                {
                    if (track.Checked)
                    {
                        return _checker(track.Image) ? "верно" : "неверно";
                    }
                    else
                    {
                        return _checker(track.Image) ? "неверно" : "верно";
                    }
                }
                return string.Empty;
            }
            throw new Exception("Invalid parameter type or value type.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str)
            {
                return !string.IsNullOrEmpty(str);
            }
            throw new Exception("Invalid value type.");
        }
    }
}
