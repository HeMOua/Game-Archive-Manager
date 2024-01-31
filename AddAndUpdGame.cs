using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSave
{
    internal partial class AddAndUpdGame : Form
    {
        private GameInfo? _gameInfo { set; get; }

        public AddAndUpdGame(GameInfo? gameInfo)
        {
            _gameInfo = gameInfo;

            InitializeComponent();

            initData();
        }

        private void initData()
        {
            if (_gameInfo == null)
            {
                Text = "添加游戏";
            }
            else
            {
                gameNameBox.Text = _gameInfo.Name;
                gamePathBox.Text = _gameInfo.Path;
                Text = "修改游戏";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gameName = gameNameBox.Text;
            string gamePath = gamePathBox.Text;

            if (string.IsNullOrEmpty(gameName))
            {
                MessageBox.Show("游戏名不可为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(gamePath))
            {
                MessageBox.Show("游戏存档路径不可为空", "提示", MessageBoxButtons.OK);
                return;
            }
            if (!Utils.IsFilePathValid(gamePath))
            {
                MessageBox.Show("游戏存档路径不合法", "提示", MessageBoxButtons.OK);
                return;
            }
            if (_gameInfo == null)
            {
                if (!Configuration.GetInstance().AddGame(gameName, gamePath))
                {
                    MessageBox.Show($"添加游戏失败，游戏\"{gameName}\"已存在！", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                Debug.Assert(_gameInfo.Name != null);
                Configuration.GetInstance().UpdGame(_gameInfo.Name, gameName, gamePath);
            }

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "请选择游戏存档目录";
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                gamePathBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
