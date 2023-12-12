using System;
using System.Configuration;
using System.IO;

namespace MemoryToolApplication.Managers
{
    internal class ConfigManager
    {
        public ConfigManager() {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None) ?? throw new Exception("Не найден конфигурационный файл в папке приложения.");
            var path = (config.AppSettings.Settings["resources"]?.Value) ?? throw new Exception("Путь к директории с ресурсами приложения не указан.");
            ResourcesDirectory = new DirectoryInfo(path);
        }

        public DirectoryInfo ResourcesDirectory { get; private set; }
    }
}
