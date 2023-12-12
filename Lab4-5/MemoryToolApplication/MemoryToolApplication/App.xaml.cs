using MemoryToolApplication.Managers;
using MemoryToolApplication.ViewModels;
using MemoryToolApplication.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MemoryToolApplication
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        private void StartApp(object sender, StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            try
            {
                var config = new ConfigManager();
                var creator = new ImagesPool(config.ResourcesDirectory);
                var window = Current.MainWindow = new MainWindow
                {
                    DataContext = new MainViewModel(creator)
                };
                window.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка. " + ex.Message);
                Shutdown();
            }
        }
    }
}
