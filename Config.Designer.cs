namespace GameSave
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            archiveBox = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            backupBox = new TextBox();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.6049347F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(354, 82);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "应用时备份：";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 0;
            label2.Text = "存档路径：";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 56);
            label3.Name = "label3";
            label3.Size = new Size(87, 26);
            label3.TabIndex = 0;
            label3.Text = "备份路径：";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Location = new Point(96, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(255, 22);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(archiveBox);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(93, 28);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 28);
            panel1.TabIndex = 2;
            // 
            // archiveBox
            // 
            archiveBox.Dock = DockStyle.Fill;
            archiveBox.Location = new Point(0, 0);
            archiveBox.Name = "archiveBox";
            archiveBox.Size = new Size(186, 23);
            archiveBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(186, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 0;
            button1.Text = "选择";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(backupBox);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(93, 56);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 26);
            panel2.TabIndex = 3;
            // 
            // backupBox
            // 
            backupBox.Dock = DockStyle.Fill;
            backupBox.Location = new Point(0, 0);
            backupBox.Name = "backupBox";
            backupBox.Size = new Size(186, 23);
            backupBox.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(186, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 0;
            button2.Text = "选择";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(10, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(354, 33);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(276, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "取消";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(195, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "确定";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 161);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1000, 200);
            MinimumSize = new Size(390, 200);
            Name = "Config";
            Padding = new Padding(10, 20, 10, 8);
            StartPosition = FormStartPosition.CenterParent;
            Text = "配置";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Panel panel1;
        private TextBox archiveBox;
        private Button button1;
        private Panel panel2;
        private TextBox backupBox;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button4;
    }
}