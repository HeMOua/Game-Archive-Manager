using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.IO.Compression;

namespace GameSave
{
    internal class Utils
    {
        public static void OpenFolder(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    Process.Start("explorer.exe", folderPath);
                }
                else
                {
                    MessageBox.Show($"文件夹\"{folderPath}\"不存在！", "提示");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开文件夹时发生错误：{ex.Message}", "提示");
            }
        }

        public static string GetValidFolderPath(string input)
        {
            foreach (char invalidChar in Path.GetInvalidPathChars())
            {
                input = input.Replace(invalidChar.ToString(), "_");
            }
            return input;
        }

        public static bool IsFilePathValid(string filePath)
        {
            // 检查路径是否为绝对路径
            if (!Path.IsPathRooted(filePath))
            {
                return false;
            }

            // 检查路径是否包含无效字符
            char[] invalidChars = Path.GetInvalidPathChars();
            if (filePath.IndexOfAny(invalidChars) != -1)
            {
                return false;
            }

            return true;
        }

        public static bool IsFolderContainsItems(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                // 获取文件夹下的文件和子文件夹
                string[] items = Directory.GetFileSystemEntries(folderPath);

                // 判断是否存在文件或文件夹
                return items.Length > 0;
            }

            // 文件夹不存在，返回false
            return false;
        }

        public static bool CheckFolderAndMove(string src, string dest)
        {
            if (IsFolderContainsItems(dest)) return false;

            if (Directory.Exists(src))
            {
                Directory.Move(src, dest);
            }
            return true;
        }

        public static string FormatFileSize(long fileSize)
        {
            const long KB = 1024;
            const long MB = 1024 * KB;
            const long GB = 1024 * MB;

            if (fileSize < KB)
            {
                return fileSize + " 字节";
            }
            else if (fileSize < MB)
            {
                double fileSizeInKB = (double)fileSize / KB;
                return fileSizeInKB.ToString("0.00") + " KB";
            }
            else if (fileSize < GB)
            {
                double fileSizeInMB = (double)fileSize / MB;
                return fileSizeInMB.ToString("0.00") + " MB";
            }
            else
            {
                double fileSizeInGB = (double)fileSize / GB;
                return fileSizeInGB.ToString("0.00") + " GB";
            }
        }

        public static void ZipFolder(string srcPath, string targetPath)
        {
            if (!Directory.Exists(srcPath))
            {
                MessageBox.Show($"源路径不存在！", "提示");
                return;
            }

            try
            {
                string? pPath = Path.GetDirectoryName(targetPath);
                if (pPath != null)
                {
                    if (!Directory.Exists(pPath))
                    {
                        Directory.CreateDirectory(pPath);
                    }
                }
                ZipFile.CreateFromDirectory(srcPath, targetPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打包游戏存档时发生错误：{ex.Message}", "提示");
            }
        }

        public static void ExtractZipFile(string zipFilePath, string extractToFolder)
        {
            try
            {
                // 如果目标目录不存在，创建目录
                if (!Directory.Exists(extractToFolder))
                {
                    Directory.CreateDirectory(extractToFolder);
                }

                // 使用ZipFile.ExtractToDirectory方法解压Zip文件
                ZipFile.ExtractToDirectory(zipFilePath, extractToFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"应用存档时发生错误：{ex.Message}", "提示");
            }
        }

        public static void MoveFiles(string sourceDirectory, string destinationDirectory)
        {
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.Move(sourceDirectory, destinationDirectory);
                return;
            }

            // 移动文件
            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destinationPath = Path.Combine(destinationDirectory, fileName);

                File.Move(file, destinationPath);
            }

            // 移动文件夹
            string[] subdirectories = Directory.GetDirectories(sourceDirectory);
            foreach (string subdirectory in subdirectories)
            {
                string subdirectoryName = Path.GetFileName(subdirectory);
                string destinationPath = Path.Combine(destinationDirectory, subdirectoryName);

                Directory.Move(subdirectory, destinationPath);
            }
            Directory.Delete(sourceDirectory);
        }

        public static string CurrentTime()
        {
            DateTime currentDateTime = DateTime.Now;

            return currentDateTime.ToString("yyyyMMdd_HHmmss");
        }
    }

    internal class YamlHelper
    {
        private static ISerializer _serializer;
        private static IDeserializer _deserializer;

        static YamlHelper()
        {
            _serializer = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            _deserializer = new DeserializerBuilder().WithNamingConvention(UnderscoredNamingConvention.Instance).Build();
        }

        public static string Serialize(object target)
        {
            return _serializer.Serialize(target);
        }

        public static void SerializeToFile(object target, string filePath)
        {
            var content = Serialize(target);
            File.WriteAllText(filePath, content, Encoding.UTF8);
        }

        public static T Deserialize<T>(string yaml)
        {
            return _deserializer.Deserialize<T>(yaml);
        }

        public static T DeserializeFromFile<T>(string filePath)
        {
            var yaml = File.ReadAllText(filePath, Encoding.UTF8);
            return Deserialize<T>(yaml);
        }
    }
}
