namespace GameSave
{
    partial class AddAndUpdGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndUpdGame));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            gamePathBox = new TextBox();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            gameNameBox = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(gameNameBox, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(460, 64);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(gamePathBox);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(101, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 26);
            panel2.TabIndex = 2;
            // 
            // gamePathBox
            // 
            gamePathBox.Dock = DockStyle.Fill;
            gamePathBox.Location = new Point(0, 0);
            gamePathBox.Name = "gamePathBox";
            gamePathBox.Size = new Size(292, 23);
            gamePathBox.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(292, 0);
            button3.Name = "button3";
            button3.Size = new Size(64, 26);
            button3.TabIndex = 0;
            button3.Text = "选择";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 0;
            label1.Text = "游戏名：";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 1;
            label2.Text = "存档路径：";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gameNameBox
            // 
            gameNameBox.Dock = DockStyle.Fill;
            gameNameBox.Location = new Point(101, 3);
            gameNameBox.Name = "gameNameBox";
            gameNameBox.Size = new Size(356, 23);
            gameNameBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 126);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 94);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 8, 0);
            flowLayoutPanel1.Size = new Size(484, 32);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(398, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddAndUpdGame
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 126);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(900, 165);
            MinimumSize = new Size(500, 165);
            Name = "AddAndUpdGame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddAndUpdGame";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private TextBox gamePathBox;
        private TextBox gameNameBox;
        private Panel panel2;
    }
}