namespace Taxi_cervice
{
    partial class DestinationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.شناسه = new System.Windows.Forms.Label();
            this.txtDestinationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDestinationAdd = new System.Windows.Forms.Button();
            this.grdDestination = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDestinationEdit = new System.Windows.Forms.Button();
            this.btnDestinationExit = new System.Windows.Forms.Button();
            this.txtDestinationSearch = new System.Windows.Forms.TextBox();
            this.txtDestinationName = new System.Windows.Forms.TextBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDestination)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // شناسه
            // 
            this.شناسه.AutoSize = true;
            this.شناسه.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.شناسه.Location = new System.Drawing.Point(67, 39);
            this.شناسه.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.شناسه.Name = "شناسه";
            this.شناسه.Size = new System.Drawing.Size(44, 20);
            this.شناسه.TabIndex = 0;
            this.شناسه.Text = "شناسه :";
            // 
            // txtDestinationID
            // 
            this.txtDestinationID.Location = new System.Drawing.Point(138, 32);
            this.txtDestinationID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationID.Name = "txtDestinationID";
            this.txtDestinationID.ReadOnly = true;
            this.txtDestinationID.Size = new System.Drawing.Size(153, 27);
            this.txtDestinationID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "مکان :";
            // 
            // btnDestinationAdd
            // 
            this.btnDestinationAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDestinationAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationAdd.Location = new System.Drawing.Point(37, 128);
            this.btnDestinationAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDestinationAdd.Name = "btnDestinationAdd";
            this.btnDestinationAdd.Size = new System.Drawing.Size(93, 27);
            this.btnDestinationAdd.TabIndex = 5;
            this.btnDestinationAdd.Text = "افزودن";
            this.btnDestinationAdd.UseVisualStyleBackColor = false;
            this.btnDestinationAdd.Click += new System.EventHandler(this.btnDestinationAdd_Click);
            // 
            // grdDestination
            // 
            this.grdDestination.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DestinationName,
            this.Remove,
            this.Update});
            this.grdDestination.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grdDestination.Location = new System.Drawing.Point(6, 262);
            this.grdDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDestination.Name = "grdDestination";
            this.grdDestination.Size = new System.Drawing.Size(460, 540);
            this.grdDestination.TabIndex = 6;
            this.grdDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDestination_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "DestinationID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            // 
            // DestinationName
            // 
            this.DestinationName.DataPropertyName = "DestinationsName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DestinationName.DefaultCellStyle = dataGridViewCellStyle2;
            this.DestinationName.HeaderText = "نام";
            this.DestinationName.Name = "DestinationName";
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Remove.DefaultCellStyle = dataGridViewCellStyle3;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.HeaderText = "حذف";
            this.Remove.Name = "Remove";
            this.Remove.Text = "حذف";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Update.DefaultCellStyle = dataGridViewCellStyle4;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "ویرایش";
            this.Update.Name = "Update";
            this.Update.Text = "ویرایش";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // btnDestinationEdit
            // 
            this.btnDestinationEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDestinationEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationEdit.Location = new System.Drawing.Point(138, 128);
            this.btnDestinationEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDestinationEdit.Name = "btnDestinationEdit";
            this.btnDestinationEdit.Size = new System.Drawing.Size(96, 27);
            this.btnDestinationEdit.TabIndex = 7;
            this.btnDestinationEdit.Text = "ثبت تغییرات";
            this.btnDestinationEdit.UseVisualStyleBackColor = false;
            this.btnDestinationEdit.Click += new System.EventHandler(this.btnDestinationEdit_Click);
            // 
            // btnDestinationExit
            // 
            this.btnDestinationExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDestinationExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationExit.Location = new System.Drawing.Point(242, 128);
            this.btnDestinationExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDestinationExit.Name = "btnDestinationExit";
            this.btnDestinationExit.Size = new System.Drawing.Size(90, 27);
            this.btnDestinationExit.TabIndex = 8;
            this.btnDestinationExit.Text = "بازگشت";
            this.btnDestinationExit.UseVisualStyleBackColor = false;
            this.btnDestinationExit.Click += new System.EventHandler(this.btnDestinationExit_Click);
            // 
            // txtDestinationSearch
            // 
            this.txtDestinationSearch.Location = new System.Drawing.Point(164, 14);
            this.txtDestinationSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationSearch.Name = "txtDestinationSearch";
            this.txtDestinationSearch.Size = new System.Drawing.Size(180, 27);
            this.txtDestinationSearch.TabIndex = 10;
            // 
            // txtDestinationName
            // 
            this.txtDestinationName.Location = new System.Drawing.Point(138, 72);
            this.txtDestinationName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationName.Name = "txtDestinationName";
            this.txtDestinationName.Size = new System.Drawing.Size(153, 27);
            this.txtDestinationName.TabIndex = 11;
            this.txtDestinationName.TextChanged += new System.EventHandler(this.txtDestinationName_TextChanged);
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerch.Location = new System.Drawing.Point(49, 11);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(81, 27);
            this.btnSerch.TabIndex = 12;
            this.btnSerch.Text = "جست و جو";
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "مکان :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSerch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDestinationSearch);
            this.panel1.Location = new System.Drawing.Point(13, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 70);
            this.panel1.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(141)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(358, 128);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 27);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 800);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDestinationName);
            this.Controls.Add(this.btnDestinationExit);
            this.Controls.Add(this.btnDestinationEdit);
            this.Controls.Add(this.grdDestination);
            this.Controls.Add(this.btnDestinationAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestinationID);
            this.Controls.Add(this.شناسه);
            this.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DestinationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مقصد";
            this.Load += new System.EventHandler(this.DestinationForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdDestination)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label شناسه;
        private System.Windows.Forms.TextBox txtDestinationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDestinationAdd;
        private System.Windows.Forms.DataGridView grdDestination;
        private System.Windows.Forms.Button btnDestinationEdit;
        private System.Windows.Forms.Button btnDestinationExit;
        private System.Windows.Forms.TextBox txtDestinationSearch;
        private System.Windows.Forms.TextBox txtDestinationName;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationName;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}