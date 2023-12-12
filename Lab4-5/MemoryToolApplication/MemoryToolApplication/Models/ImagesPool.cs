using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MemoryToolApplication.Managers
{
    internal class ImagesPool
    {
        readonly List<BitmapImage> _images;

        public List<BitmapImage> Images => _images;

        public ImagesPool(DirectoryInfo directory)
        {
            var files = directory.GetFiles();
            _images = new List<BitmapImage>(files.Length);
            foreach (var file in files)
            {
                var uri = new Uri(file.FullName, UriKind.RelativeOrAbsolute);
                _images.Add(new BitmapImage(uri));
            }
        }
    }
}
