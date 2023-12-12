using MemoryToolApplication.Managers;
using MemoryToolLibrary.Managers;
using MemoryToolLibrary.MVVM;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MemoryToolApplication.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        ImagesPool _pool;
        TestManager _tester;
        List<BitmapImage> _images;
        TimerManager _timer;

        public int ImagesCount { get; set; } = 4;

        public int ShowDuration { get; set; } = 5;

        ICommand _cmdShowImages;
        public ICommand CmdShowImages => _cmdShowImages ?? (_cmdShowImages = new ExecutableCommand(ShowPictures));

        ICommand _cmdStartTest;
        public ICommand CmdStartTest => _cmdStartTest ?? (_cmdStartTest = new ExecutableCommand(StartTest));

        ICommand _cmdFinishTest;
        public ICommand CmdFinishTest => _cmdFinishTest ?? (_cmdFinishTest = new ExecutableCommand(FinishTest));

        void ShowPictures(object obj)
        {
            if (obj is Grid panel)
            {
                if (_timer == null)
                {
                    _timer = new TimerManager(() => panel.Dispatcher?.Invoke(() => panel.Children.Clear()));
                }
                _timer.Stop();

                panel.Children.Clear();
                _images = RandomSorter.CreateRandomlySortedList(_pool.Images, 2 * ImagesCount);
                var images = RandomSorter.CreateRandomlySortedList(_images, ImagesCount);
                foreach (var image in images)
                {
                    panel.Children.Add(WidgetsCreator.CreateOrdinaryImage(image));
                }
                ImagesPanelManager.UpdateLayout(panel);
                _tester = new TestManager(images);

                _timer.Start(ShowDuration);
            }
        }

        void StartTest(object obj)
        {
            if (obj is Grid panel)
            {
                panel.Children.Clear();
                foreach (var image in _images)
                {
                    panel.Children.Add(WidgetsCreator.CreateClickableImage(image, _tester));
                }
                ImagesPanelManager.UpdateLayout(panel);
                _tester.IsShowResults = false;
            }
        }

        void FinishTest(object _)
        {
            _tester.IsShowResults = true;
        }

        public MainViewModel(ImagesPool creator)
        {
            _pool = creator;
        }

        ~MainViewModel()
        {
            _timer.Stop();
        }
    }
}
