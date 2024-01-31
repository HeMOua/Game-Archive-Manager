using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace GameSave
{
    internal class Configuration
    {

        public static string ConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONFIG_FILE_NAME);

        private static Configuration? INSTANCE;

        [YamlMember(Alias = "backup")]
        public string BackupFolderPath { get; set; }

        [YamlMember(Alias = "archive")]
        public string ArchiveFolderPath { get; set; }

        [YamlMember(Alias = "backuponapply")]
        public bool BackupOnApply { get; set; }

        [YamlMember(Alias = "games")]
        public List<GameInfo> GameInfoList = new List<GameInfo>();

        private const string CONFIG_FILE_NAME = "config.yaml";
        private const string BACKUP_FOLDER_NAME = "backup";
        private const string ARCHIVE_FOLDER_NAME = "archive";

        public Configuration()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            BackupFolderPath = Path.Combine(basePath, BACKUP_FOLDER_NAME);
            ArchiveFolderPath = Path.Combine(basePath, ARCHIVE_FOLDER_NAME);
            BackupOnApply = true;
        }

        public static Configuration GetInstance()
        {
            if (INSTANCE == null)
            {
                if (File.Exists(ConfigFilePath))
                {
                    INSTANCE = ReadConfig();
                    WriteConfig(INSTANCE);
                }
                else
                {
                    INSTANCE = new Configuration();
                }
            }
            return INSTANCE;
        }

        public static Configuration ReadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                try
                {
                    Configuration configuration = YamlHelper.DeserializeFromFile<Configuration>(ConfigFilePath);
                    if (configuration.GameInfoList == null) configuration.GameInfoList = new List<GameInfo>();
                    return configuration;
                }
                catch (Exception)
                {
                    MessageBox.Show("配置文件格式错误，将使用默认配置！", "提示");
                    File.Move(ConfigFilePath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONFIG_FILE_NAME + ".bak"));
                }
            }
            return new Configuration();
        }

        public void WriteConfig()
        {
            YamlHelper.SerializeToFile(this, ConfigFilePath);
        }

        public static void WriteConfig(Configuration obj)
        {
            YamlHelper.SerializeToFile(obj, ConfigFilePath);
        }

        public bool AddGame(string name, string path)
        {
            if (!GameInfoList.Any(x => x.Name == name))
            {
                GameInfoList.Add(new GameInfo(name, path));
                WriteConfig();
                return true;
            }
            return false;
        }

        public bool DelGame(string name)
        {
            GameInfo? info = GetGame(name);
            if (info != null)
            {
                GameInfoList.RemoveAll(x => x.Name == name);
                WriteConfig();

                string path = Path.Combine(ArchiveFolderPath, Utils.GetValidFolderPath(name));
                if (Directory.Exists(path)) Directory.Delete(path, true);
                return true;
            }
            return false;
        }

        public bool UpdGame(string oldName, string name, string path)
        {

            string oldPath = Path.Combine(ArchiveFolderPath, Utils.GetValidFolderPath(oldName));
            string newPath = Path.Combine(ArchiveFolderPath, Utils.GetValidFolderPath(name));

            GameInfo? info= GetGame(oldName);
            if (info!= null)
            {
                info.Name = name;
                info.Path = path;
                WriteConfig();

                if (Directory.Exists(oldPath) && oldPath != newPath)
                {
                    Directory.Move(oldPath, newPath);
                }

                return true;
            }
            return false;
        }

        public GameInfo? GetGame(string name)
        {
            return GameInfoList.FirstOrDefault(person => person.Name == name);
        }

        public List<GameInfo> GetGames()
        {
            return GameInfoList;
        }
    }

    internal class GameInfo
    {
        [YamlMember(Alias = "name")]
        public string? Name { get; set; }

        [YamlMember(Alias = "path")]
        public string? Path { get; set; }

        public GameInfo() { }

        public GameInfo(string? name, string? path)
        {
            Name = name;
            Path = path;
        }
    }
}
