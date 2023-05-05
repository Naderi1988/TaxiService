namespace Taxi_cervice
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مدیریتکارمندانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رانندگانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رزویشنهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتسفرهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتمشتریانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتخودروهاStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMainForm = new System.Windows.Forms.ToolStrip();
            this.lblUserName = new System.Windows.Forms.ToolStripLabel();
            this.lblDate = new System.Windows.Forms.ToolStripLabel();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tlsMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکارمندانToolStripMenuItem,
            this.مدیریتسفرهاToolStripMenuItem,
            this.مدیریتمشتریانToolStripMenuItem,
            this.مدیریتخودروهاStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(933, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
           
            // 
            // مدیریتکارمندانToolStripMenuItem
            // 
            this.مدیریتکارمندانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.رانندگانToolStripMenuItem,
            this.رزویشنهاToolStripMenuItem});
            this.مدیریتکارمندانToolStripMenuItem.Name = "مدیریتکارمندانToolStripMenuItem";
            this.مدیریتکارمندانToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.مدیریتکارمندانToolStripMenuItem.Text = "مدیریت کارمندان";
            // 
            // رانندگانToolStripMenuItem
            // 
            this.رانندگانToolStripMenuItem.Name = "رانندگانToolStripMenuItem";
            this.رانندگانToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.رانندگانToolStripMenuItem.Text = "مدیریت رانندگان";
            this.رانندگانToolStripMenuItem.Click += new System.EventHandler(this.رانندگانToolStripMenuItem_Click);
            // 
            // رزویشنهاToolStripMenuItem
            // 
            this.رزویشنهاToolStripMenuItem.Name = "رزویشنهاToolStripMenuItem";
            this.رزویشنهاToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.رزویشنهاToolStripMenuItem.Text = "مدیریت رزویشن ها";
            this.رزویشنهاToolStripMenuItem.Click += new System.EventHandler(this.رزویشنهاToolStripMenuItem_Click);
            // 
            // مدیریتسفرهاToolStripMenuItem
            // 
            this.مدیریتسفرهاToolStripMenuItem.Name = "مدیریتسفرهاToolStripMenuItem";
            this.مدیریتسفرهاToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.مدیریتسفرهاToolStripMenuItem.Text = "مدیریت سفرها";
            this.مدیریتسفرهاToolStripMenuItem.Click += new System.EventHandler(this.مدیریتسفرهاToolStripMenuItem_Click);
            // 
            // مدیریتمشتریانToolStripMenuItem
            // 
            this.مدیریتمشتریانToolStripMenuItem.Name = "مدیریتمشتریانToolStripMenuItem";
            this.مدیریتمشتریانToolStripMenuItem.Size = new System.Drawing.Size(102, 19);
            this.مدیریتمشتریانToolStripMenuItem.Text = "مدیریت مشتریان";
            this.مدیریتمشتریانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتمشتریانToolStripMenuItem_Click);
            // 
            // مدیریتخودروهاStripMenuItem
            // 
            this.مدیریتخودروهاStripMenuItem.Name = "مدیریتخودروهاStripMenuItem";
            this.مدیریتخودروهاStripMenuItem.Size = new System.Drawing.Size(100, 19);
            this.مدیریتخودروهاStripMenuItem.Text = "مدیریت خودروها";
            this.مدیریتخودروهاStripMenuItem.Click += new System.EventHandler(this.مدیریتخودروهاStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // tlsMainForm
            // 
            this.tlsMainForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserName,
            this.lblDate,
            this.lblTime});
            this.tlsMainForm.Location = new System.Drawing.Point(0, 563);
            this.tlsMainForm.Name = "tlsMainForm";
            this.tlsMainForm.Size = new System.Drawing.Size(933, 25);
            this.tlsMainForm.TabIndex = 3;
            this.tlsMainForm.Text = "toolStrip1";
            // 
            // lblUserName
            // 
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(86, 22);
            this.lblUserName.Text = "toolStripLabel1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 22);
            this.lblDate.Text = "toolStripLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 22);
            this.lblTime.Text = "tlsTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.tlsMainForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Mitra", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت تاکسی سرویس";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlsMainForm.ResumeLayout(false);
            this.tlsMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مدیریتسفرهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتمشتریانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکارمندانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رانندگانToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlsMainForm;
        private System.Windows.Forms.ToolStripLabel lblUserName;
        private System.Windows.Forms.ToolStripLabel lblDate;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem رزویشنهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتخودروهاStripMenuItem;
    }
}