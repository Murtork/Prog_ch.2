using MemoryToolApplication.ViewModels;
using MemoryToolLibrary.Converters;
using MemoryToolLibrary.Managers;
using MemoryToolLibrary.MVVM;
using System.Collections.Generic;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MemoryToolApplication.Managers
{
    internal class TestManager : BaseViewModel
    {
        readonly List<BitmapImage> _images;
        readonly List<ImageTracker> _tracks;
        bool _isShowResults = false;

        public TestManager(List<BitmapImage> images)
        {
            _images = images;
            _tracks = new List<ImageTracker>(images.Count);
        }

        public void BindCheck(ClickableImageViewModel viewModel)
        {
            var track = new ImageTracker(viewModel.Image);
            _tracks.Add(track);
            var binding = new Binding("IsChecked")
            {
                Source = viewModel
            };
            BindingOperations.SetBinding(track, ImageTracker.CheckedProperty, binding);
            binding = new Binding("IsShowResults")
            {
                Source = this,
                Converter = new TrackToStringConverter(x => _images.Contains(x)),
                ConverterParameter = track
            };
            BindingOperations.SetBinding(viewModel, ClickableImageViewModel.InfoTextProperty, binding);
            binding = new Binding("IsShowResults")
            {
                Source = this,
                Converter = new BooleanInverter()
            };
            BindingOperations.SetBinding(viewModel, ClickableImageViewModel.IsEnabledProperty, binding);
        }

        public bool IsShowResults
        {
            get => _isShowResults;
            set
            {
                _isShowResults = value;
                OnPropertyChanged(nameof(IsShowResults));
            }
        }


    }
}
