using MemoryToolApplication.ViewModels;
using MemoryToolApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MemoryToolApplication.Managers
{
    internal class WidgetsCreator
    {
        static void CalculateSize(double w, double h, out double nw, out double nh)
        {
            if (w > h)
            {
                nw = Size;
                nh = h / w * Size;
            }
            else
            {
                nh = Size;
                nw = w / h * Size;
            }
        }

        public static ClickableImage CreateClickableImage(BitmapImage image, TestManager manager)
        {
            CalculateSize(image.Width, image.Height, out double width, out double height);
            return new ClickableImage
            {
                DataContext = new ClickableImageViewModel(image, width, height, manager),
                Margin = new Thickness(Margin),
            };
        }

        public static Image CreateOrdinaryImage(BitmapImage image)
        {
            CalculateSize(image.Width, image.Height, out double width, out double height);
            return new Image
            {
                Width = width,
                Height = height,
                Margin = new Thickness(Margin),
                Source = image,

            };
        }

        public const double Size = 200;

        public const double Margin = 5;
    }
}
