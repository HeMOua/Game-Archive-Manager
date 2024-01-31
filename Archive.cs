using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSave
{
    internal class Archive
    {

        private string _suffix = ".zip";

        public string RawArchivePath { get; set; }

        public string ArchivePath { get; set; }

        public string GameName { get; set; }

        public List<ArchiveItem> Items = new List<ArchiveItem>();

        public Archive(string gameName, string rawArchivePath) 
        {
            RawArchivePath = rawArchivePath;
            GameName = gameName;
            ArchivePath = Path.Combine(Configuration.GetInstance().ArchiveFolderPath, Utils.GetValidFolderPath(gameName));
        }


        public void ScanArchive()
        {
            if (Directory.Exists(ArchivePath))
            {
                Items.Clear();
                string[] files = Directory.GetFiles(ArchivePath);
                foreach (string file in files)
                {
                    Items.Add(new ArchiveItem(file));
                }
            }
        }

        public void AddArchive()
        {
            string zipPath = Path.Combine(ArchivePath, Utils.CurrentTime() + _suffix);
            Utils.ZipFolder(RawArchivePath, zipPath);
        }

        public void DelArchive(string archiveName)
        {
            string filePath = Path.Combine(ArchivePath, archiveName);
            if (File.Exists(filePath)) 
            { 
                File.Delete(filePath);
            }
        }

        public void ApplyArchive(string archiveName)
        {
            // 备份并删除旧目录
            if (Directory.Exists(RawArchivePath))
            {
                if (Configuration.GetInstance().BackupOnApply)
                {
                    string backupZipPath = Path.Combine(Configuration.GetInstance().BackupFolderPath, $"{GameName}_{Utils.CurrentTime()}{_suffix}");
                    Utils.ZipFolder(RawArchivePath, backupZipPath);
                }
                Directory.Delete(RawArchivePath, true);
            }
            // 应用存档
            string zipPath = Path.Combine(ArchivePath, archiveName);
            Utils.ExtractZipFile(zipPath, RawArchivePath);
        }
    }

    internal class ArchiveItem
    {
        public string Name { get; set; }

        public string CreateTime { get; set; }

        public string Size { get; set; }

        public ArchiveItem(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            Name = fileInfo.Name;
            CreateTime = fileInfo.CreationTime.ToString();
            Size = Utils.FormatFileSize(fileInfo.Length);
        }

        public override string? ToString()
        {
            return base.ToString() + ",Name: " + Name + ", CreateTime: " + CreateTime + ", Size: " + Size;
        }
    }

}
