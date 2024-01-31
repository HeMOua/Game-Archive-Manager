namespace GameSave
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 31);
            label1.TabIndex = 0;
            label1.Text = "游戏存档管理器";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(linkLabel1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 20);
            tableLayoutPanel1.Margin = new Padding(3, 20, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(252, 123);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(246, 31);
            label2.TabIndex = 1;
            label2.Text = "版本：0.1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(246, 20);
            label3.TabIndex = 2;
            label3.Text = "作者：HeMOu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 102);
            label4.Name = "label4";
            label4.Size = new Size(246, 21);
            label4.TabIndex = 3;
            label4.Text = "Copyright © 2024";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Fill;
            linkLabel1.Location = new Point(3, 82);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(246, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/HeMOua";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 193);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            Padding = new Padding(0, 20, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "关于";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}