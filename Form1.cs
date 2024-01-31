using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameSave
{
    public partial class Form1 : Form
    {

        private bool _selectedGame = false;
        private Archive? archive;

        public Form1()
        {
            InitializeComponent();
            refreshData();

            setHeaderText();
        }

        private void setHeaderText()
        {
            gameGridView.Columns[0].HeaderText = "游戏名";
            gameGridView.Columns[1].HeaderText = "源存档路径";


            archiveGridView.Columns[0].HeaderText = "存档名";
            archiveGridView.Columns[1].HeaderText = "创建时间";
            archiveGridView.Columns[2].HeaderText = "大小";
        }

        private void refreshData()
        {
            if (gameGridView.DataSource == null)
                gameGridView.DataSource = new BindingList<GameInfo>();
            BindingList<GameInfo> dataSource = (BindingList<GameInfo>)gameGridView.DataSource;
            dataSource.Clear();
            foreach (GameInfo info in Configuration.GetInstance().GameInfoList)
            {
                dataSource.Add(info);
            }
            gameGridView.Refresh();
        }

        private void refreshArchiveData(string gameName, string rawArchivePath)
        {
            archive = new Archive(gameName, rawArchivePath);
            refreshArchiveData();
        }


        private void refreshArchiveData()
        {
            if (archiveGridView.DataSource == null)
                archiveGridView.DataSource = new BindingList<ArchiveItem>();
            BindingList<ArchiveItem> dataSource = (BindingList<ArchiveItem>)archiveGridView.DataSource;
            dataSource.Clear();
            if (archive != null)
            {
                archive.ScanArchive();
                foreach (ArchiveItem info in archive.Items)
                {
                    dataSource.Add(info);
                }
            }
            archiveGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddAndUpdGame(null).ShowDialog(this);
            refreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = gameGridView.SelectedRows;
            if (selectedRows.Count > 0)
            {
                string? name = selectedRows[0].Cells["Name"].Value?.ToString();
                string? path = selectedRows[0].Cells["Path"].Value?.ToString();
                new AddAndUpdGame(new GameInfo(name, path)).ShowDialog(this);
                refreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = gameGridView.SelectedRows;
            string? name = selectedRows[0].Cells["Name"].Value?.ToString();
            if (selectedRows.Count > 0 && !string.IsNullOrEmpty(name))
            {
                DialogResult dialogResult = MessageBox.Show($"确定删除\"{name}\"的所有游戏存档吗？", "删除游戏", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes && name != null)
                {
                    Configuration.GetInstance().DelGame(name);
                    refreshData();
                }
            }
        }

        private void gameGridView_SelectionChanged(object sender, EventArgs e)
        {
            RefreshSelect();
        }

        public void RefreshSelect()
        {
            bool enable = gameGridView.SelectedRows.Count > 0;
            updGameBtn.Enabled = enable;
            delGameBtn.Enabled = enable;
            _selectedGame = enable;
            addArchiveBtn.Enabled = enable;
            openRawArchiveBtn.Enabled = enable;

            if (enable)
            {
                DataGridViewSelectedRowCollection selectedRows = gameGridView.SelectedRows;
                string? name = selectedRows[0].Cells["Name"].Value?.ToString();
                string? path = selectedRows[0].Cells["Path"].Value?.ToString();
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(path))
                {
                    string archivePath = Path.Combine(Configuration.GetInstance().ArchiveFolderPath, name);
                    archiveGroupBox.Text = $"[{name}] - 存档管理";
                    tipLabel.Text = $"存档备份位置：{archivePath}";
                    refreshArchiveData(name, path);
                }
            }
            else
            {
                archiveGroupBox.Text = "存档管理";
                tipLabel.Text = "请选择游戏";
                archive = null;
                refreshArchiveData();
            }
        }

        private void addArchiveBtn_Click(object sender, EventArgs e)
        {
            if (archive != null)
            {
                archive.AddArchive();
                refreshArchiveData();
            }
        }

        private void applyArchiveBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = archiveGridView.SelectedRows;
            string? name = selectedRows[0].Cells["Name"].Value?.ToString();
            if (archive != null && name != null)
            {
                archive.ApplyArchive(name);
                MessageBox.Show($"已为\"{archive.GameName}\"加载\"{name}\"存档！", "提示");
            }
        }

        private void delArchiveBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = archiveGridView.SelectedRows;
            string? name = selectedRows[0].Cells["Name"].Value?.ToString();
            if (selectedRows.Count > 0 && !string.IsNullOrEmpty(name) && archive != null)
            {
                DialogResult dialogResult = MessageBox.Show($"确定删除游戏\"{archive.GameName}\"的\"{name}\"存档吗？", "删除存档", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes && name != null)
                {
                    archive.DelArchive(name);
                    refreshArchiveData();
                }
            }
        }
        private void archiveGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool enable = archiveGridView.SelectedRows.Count > 0;
            applyArchiveBtn.Enabled = enable;
            delArchiveBtn.Enabled = enable;
            openArchiveBtn.Enabled = enable;
        }

        private void openRawArchiveBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = gameGridView.SelectedRows;
            string? path = selectedRows[0].Cells["Path"].Value?.ToString();
            if (path != null)
            {
                Utils.OpenFolder(path);
            }
        }

        private void openArchiveBtn_Click(object sender, EventArgs e)
        {
            if (archive != null)
            {
                Utils.OpenFolder(archive.ArchivePath);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Config(this).ShowDialog();
        }
    }
}