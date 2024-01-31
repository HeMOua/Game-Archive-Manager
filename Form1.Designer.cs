namespace GameSave
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            gameGridView = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            updGameBtn = new Button();
            delGameBtn = new Button();
            openRawArchiveBtn = new Button();
            archiveGroupBox = new GroupBox();
            archiveGridView = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            addArchiveBtn = new Button();
            applyArchiveBtn = new Button();
            delArchiveBtn = new Button();
            openArchiveBtn = new Button();
            tipLabel = new Label();
            menuStrip1 = new MenuStrip();
            选项ToolStripMenuItem = new ToolStripMenuItem();
            配置ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            archiveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)archiveGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gameGridView);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 389);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "游戏管理";
            // 
            // gameGridView
            // 
            gameGridView.AllowUserToAddRows = false;
            gameGridView.AllowUserToDeleteRows = false;
            gameGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gameGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gameGridView.BackgroundColor = SystemColors.Control;
            gameGridView.BorderStyle = BorderStyle.None;
            gameGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameGridView.Dock = DockStyle.Fill;
            gameGridView.Location = new Point(3, 51);
            gameGridView.Name = "gameGridView";
            gameGridView.ReadOnly = true;
            gameGridView.RowTemplate.Height = 25;
            gameGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gameGridView.Size = new Size(330, 335);
            gameGridView.TabIndex = 1;
            gameGridView.SelectionChanged += gameGridView_SelectionChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(updGameBtn);
            flowLayoutPanel1.Controls.Add(delGameBtn);
            flowLayoutPanel1.Controls.Add(openRawArchiveBtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(330, 32);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updGameBtn
            // 
            updGameBtn.Enabled = false;
            updGameBtn.Location = new Point(84, 3);
            updGameBtn.Name = "updGameBtn";
            updGameBtn.Size = new Size(75, 23);
            updGameBtn.TabIndex = 1;
            updGameBtn.Text = "编辑";
            updGameBtn.UseVisualStyleBackColor = true;
            updGameBtn.Click += button2_Click;
            // 
            // delGameBtn
            // 
            delGameBtn.Enabled = false;
            delGameBtn.Location = new Point(165, 3);
            delGameBtn.Name = "delGameBtn";
            delGameBtn.Size = new Size(75, 23);
            delGameBtn.TabIndex = 2;
            delGameBtn.Text = "删除";
            delGameBtn.UseVisualStyleBackColor = true;
            delGameBtn.Click += button3_Click;
            // 
            // openRawArchiveBtn
            // 
            openRawArchiveBtn.Enabled = false;
            openRawArchiveBtn.Location = new Point(246, 3);
            openRawArchiveBtn.Name = "openRawArchiveBtn";
            openRawArchiveBtn.Size = new Size(75, 23);
            openRawArchiveBtn.TabIndex = 3;
            openRawArchiveBtn.Text = "打开目录";
            openRawArchiveBtn.UseVisualStyleBackColor = true;
            openRawArchiveBtn.Click += openRawArchiveBtn_Click;
            // 
            // archiveGroupBox
            // 
            archiveGroupBox.Controls.Add(archiveGridView);
            archiveGroupBox.Controls.Add(tableLayoutPanel2);
            archiveGroupBox.Dock = DockStyle.Fill;
            archiveGroupBox.Location = new Point(0, 0);
            archiveGroupBox.Name = "archiveGroupBox";
            archiveGroupBox.Size = new Size(418, 389);
            archiveGroupBox.TabIndex = 1;
            archiveGroupBox.TabStop = false;
            archiveGroupBox.Text = "存档管理";
            // 
            // archiveGridView
            // 
            archiveGridView.AllowUserToAddRows = false;
            archiveGridView.AllowUserToDeleteRows = false;
            archiveGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            archiveGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            archiveGridView.BackgroundColor = SystemColors.Control;
            archiveGridView.BorderStyle = BorderStyle.None;
            archiveGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            archiveGridView.Dock = DockStyle.Fill;
            archiveGridView.GridColor = SystemColors.Control;
            archiveGridView.Location = new Point(3, 69);
            archiveGridView.Name = "archiveGridView";
            archiveGridView.ReadOnly = true;
            archiveGridView.RowTemplate.Height = 25;
            archiveGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            archiveGridView.Size = new Size(412, 317);
            archiveGridView.TabIndex = 1;
            archiveGridView.SelectionChanged += archiveGridView_SelectionChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel2.Controls.Add(tipLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel2.Size = new Size(412, 50);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(addArchiveBtn);
            flowLayoutPanel2.Controls.Add(applyArchiveBtn);
            flowLayoutPanel2.Controls.Add(delArchiveBtn);
            flowLayoutPanel2.Controls.Add(openArchiveBtn);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 22);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(412, 28);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // addArchiveBtn
            // 
            addArchiveBtn.Enabled = false;
            addArchiveBtn.Location = new Point(3, 3);
            addArchiveBtn.Name = "addArchiveBtn";
            addArchiveBtn.Size = new Size(75, 23);
            addArchiveBtn.TabIndex = 0;
            addArchiveBtn.Text = "创建";
            addArchiveBtn.UseVisualStyleBackColor = true;
            addArchiveBtn.Click += addArchiveBtn_Click;
            // 
            // applyArchiveBtn
            // 
            applyArchiveBtn.Enabled = false;
            applyArchiveBtn.Location = new Point(84, 3);
            applyArchiveBtn.Name = "applyArchiveBtn";
            applyArchiveBtn.Size = new Size(75, 23);
            applyArchiveBtn.TabIndex = 1;
            applyArchiveBtn.Text = "加载";
            applyArchiveBtn.UseVisualStyleBackColor = true;
            applyArchiveBtn.Click += applyArchiveBtn_Click;
            // 
            // delArchiveBtn
            // 
            delArchiveBtn.Enabled = false;
            delArchiveBtn.Location = new Point(165, 3);
            delArchiveBtn.Name = "delArchiveBtn";
            delArchiveBtn.Size = new Size(75, 23);
            delArchiveBtn.TabIndex = 2;
            delArchiveBtn.Text = "删除";
            delArchiveBtn.UseVisualStyleBackColor = true;
            delArchiveBtn.Click += delArchiveBtn_Click;
            // 
            // openArchiveBtn
            // 
            openArchiveBtn.Enabled = false;
            openArchiveBtn.Location = new Point(246, 3);
            openArchiveBtn.Name = "openArchiveBtn";
            openArchiveBtn.Size = new Size(75, 23);
            openArchiveBtn.TabIndex = 3;
            openArchiveBtn.Text = "打开目录";
            openArchiveBtn.UseVisualStyleBackColor = true;
            openArchiveBtn.Click += openArchiveBtn_Click;
            // 
            // tipLabel
            // 
            tipLabel.AutoEllipsis = true;
            tipLabel.AutoSize = true;
            tipLabel.Dock = DockStyle.Fill;
            tipLabel.Location = new Point(3, 0);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(406, 22);
            tipLabel.TabIndex = 1;
            tipLabel.Text = "请选择游戏";
            tipLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 选项ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(758, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            选项ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 配置ToolStripMenuItem, toolStripSeparator1, 退出ToolStripMenuItem });
            选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            选项ToolStripMenuItem.Size = new Size(44, 21);
            选项ToolStripMenuItem.Text = "选项";
            // 
            // 配置ToolStripMenuItem
            // 
            配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            配置ToolStripMenuItem.Size = new Size(100, 22);
            配置ToolStripMenuItem.Text = "配置";
            配置ToolStripMenuItem.Click += 配置ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(97, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(100, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 关于ToolStripMenuItem });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(100, 22);
            关于ToolStripMenuItem.Text = "关于";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(archiveGroupBox);
            splitContainer1.Size = new Size(758, 389);
            splitContainer1.SplitterDistance = 336;
            splitContainer1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 414);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(550, 440);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "游戏存档管理";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            archiveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)archiveGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button updGameBtn;
        private Button delGameBtn;
        private GroupBox archiveGroupBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button addArchiveBtn;
        private Button applyArchiveBtn;
        private Button delArchiveBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 选项ToolStripMenuItem;
        private ToolStripMenuItem 配置ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private DataGridView gameGridView;
        private DataGridView archiveGridView;
        private Label tipLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private SplitContainer splitContainer1;
        private Button openRawArchiveBtn;
        private Button openArchiveBtn;
    }
}