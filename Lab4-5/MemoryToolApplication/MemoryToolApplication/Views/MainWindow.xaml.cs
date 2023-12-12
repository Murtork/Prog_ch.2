using MemoryToolApplication.Managers;
using MemoryToolApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MemoryToolApplication.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnTestButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button == StartTestButton)
                {
                    StartTestButton.Visibility = Visibility.Collapsed;
                    FinishTestButton.Visibility = Visibility.Visible;
                    InfoTextBlock.Text = "Выберите изображения, которые наблюдали на предыдущем шаге";
                }
                else if (button == FinishTestButton)
                {
                    StartTestButton.Visibility = Visibility.Visible;
                    FinishTestButton.Visibility = Visibility.Collapsed;
                    InfoTextBlock.Text = string.Empty;
                }
            }

        }

        void OnShowButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                StartTestButton.IsEnabled = true;
                OnTestButtonClick(FinishTestButton, null);
                InfoTextBlock.Text = "Запомните изображения и нажмите на кнопку, чтобы начать тест";
            }
        }

        void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (sender is Grid panel)
            {
                ImagesPanelManager.UpdateLayout(panel);
            }

        }
    }
}
