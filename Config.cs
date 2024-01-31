using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSave
{
    public partial class Config : Form
    {

        private Form1 _parent;

        public Config(Form1 p)
        {
            InitializeComponent();
            _parent = p;
            checkBox1.Checked = Configuration.GetInstance().BackupOnApply;
            archiveBox.Text = Configuration.GetInstance().ArchiveFolderPath;
            backupBox.Text = Configuration.GetInstance().BackupFolderPath;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oldArchivePath = Configuration.GetInstance().ArchiveFolderPath;
            string oldBackupPath = Configuration.GetInstance().BackupFolderPath;
            bool isArchiveDiff = oldArchivePath != archiveBox.Text;
            bool isBackupDiff = oldBackupPath != backupBox.Text;


            if (isArchiveDiff)
            {
                if (!Utils.IsFilePathValid(archiveBox.Text))
                {
                    MessageBox.Show("存档路径不合法！", "提示");
                    return;
                }
                if (Utils.IsFolderContainsItems(archiveBox.Text))
                {
                    MessageBox.Show("存档路径存在其他文件！", "提示");
                    return;
                }
            }
            if (isBackupDiff)
            {
                if (!Utils.IsFilePathValid(backupBox.Text))
                {
                    MessageBox.Show("备份路径不合法！", "提示");
                    return;
                }
                if (Utils.IsFolderContainsItems(backupBox.Text))
                {
                    MessageBox.Show("备份路径存在其他文件！", "提示");
                    return;
                }
            }

            Configuration.GetInstance().BackupOnApply = checkBox1.Checked;
            Configuration.GetInstance().ArchiveFolderPath = archiveBox.Text;
            Configuration.GetInstance().BackupFolderPath = backupBox.Text;
            Configuration.GetInstance().WriteConfig();


            if (isBackupDiff && Directory.Exists(oldBackupPath))
            {
                Utils.MoveFiles(oldBackupPath, backupBox.Text);
            }
            if (isArchiveDiff && Directory.Exists(oldArchivePath))
            {
                Utils.MoveFiles(oldArchivePath, archiveBox.Text);
            }
            _parent.RefreshSelect();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "请选择游戏存档目录";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                archiveBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "请选择游戏存档目录";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                backupBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
