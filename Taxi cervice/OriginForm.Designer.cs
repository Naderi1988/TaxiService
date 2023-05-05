using System.Windows.Forms;

namespace Taxi_cervice
{
    partial class OriginForm
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
            this.grdOrigin = new System.Windows.Forms.DataGridView();
            this.btnOriginAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOriginID = new System.Windows.Forms.TextBox();
            this.شناسه = new System.Windows.Forms.Label();
            this.txtSearchOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOriginExit = new System.Windows.Forms.Button();
            this.btnOriginEdit = new System.Windows.Forms.Button();
            this.txtOriginName = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrigin)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdOrigin
            // 
            this.grdOrigin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdOrigin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrigin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OriginName,
            this.Remove,
            this.Update});
            this.grdOrigin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grdOrigin.Location = new System.Drawing.Point(5, 243);
            this.grdOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdOrigin.Name = "grdOrigin";
            this.grdOrigin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdOrigin.Size = new System.Drawing.Size(460, 431);
            this.grdOrigin.TabIndex = 12;
            this.grdOrigin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnOriginAdd
            // 
            this.btnOriginAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOriginAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginAdd.Location = new System.Drawing.Point(24, 108);
            this.btnOriginAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOriginAdd.Name = "btnOriginAdd";
            this.btnOriginAdd.Size = new System.Drawing.Size(92, 29);
            this.btnOriginAdd.TabIndex = 11;
            this.btnOriginAdd.Text = "افزودن";
            this.btnOriginAdd.UseVisualStyleBackColor = false;
            this.btnOriginAdd.Click += new System.EventHandler(this.btnOriginAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "مکان :";
            // 
            // txtOriginID
            // 
            this.txtOriginID.Location = new System.Drawing.Point(109, 23);
            this.txtOriginID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginID.Name = "txtOriginID";
            this.txtOriginID.ReadOnly = true;
            this.txtOriginID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOriginID.Size = new System.Drawing.Size(153, 27);
            this.txtOriginID.TabIndex = 8;
            // 
            // شناسه
            // 
            this.شناسه.AutoSize = true;
            this.شناسه.Location = new System.Drawing.Point(25, 30);
            this.شناسه.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.شناسه.Name = "شناسه";
            this.شناسه.Size = new System.Drawing.Size(44, 20);
            this.شناسه.TabIndex = 7;
            this.شناسه.Text = "شناسه :";
            // 
            // txtSearchOrigin
            // 
            this.txtSearchOrigin.Location = new System.Drawing.Point(134, 22);
            this.txtSearchOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchOrigin.Name = "txtSearchOrigin";
            this.txtSearchOrigin.Size = new System.Drawing.Size(158, 27);
            this.txtSearchOrigin.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "جست و جو";
            // 
            // btnOriginExit
            // 
            this.btnOriginExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOriginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginExit.Location = new System.Drawing.Point(229, 108);
            this.btnOriginExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOriginExit.Name = "btnOriginExit";
            this.btnOriginExit.Size = new System.Drawing.Size(101, 29);
            this.btnOriginExit.TabIndex = 15;
            this.btnOriginExit.Text = "بازگشت";
            this.btnOriginExit.UseVisualStyleBackColor = false;
            this.btnOriginExit.Click += new System.EventHandler(this.btnOriginExit_Click);
            // 
            // btnOriginEdit
            // 
            this.btnOriginEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOriginEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginEdit.Location = new System.Drawing.Point(124, 108);
            this.btnOriginEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOriginEdit.Name = "btnOriginEdit";
            this.btnOriginEdit.Size = new System.Drawing.Size(97, 29);
            this.btnOriginEdit.TabIndex = 14;
            this.btnOriginEdit.Text = "ثبت تغییرات";
            this.btnOriginEdit.UseVisualStyleBackColor = false;
            this.btnOriginEdit.Click += new System.EventHandler(this.btnOriginEdit_Click);
            // 
            // txtOriginName
            // 
            this.txtOriginName.Location = new System.Drawing.Point(109, 60);
            this.txtOriginName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginName.Name = "txtOriginName";
            this.txtOriginName.Size = new System.Drawing.Size(153, 27);
            this.txtOriginName.TabIndex = 18;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchOrigin);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Location = new System.Drawing.Point(22, 148);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(419, 71);
            this.pnlSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(55, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 29);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(141)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(353, 108);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 29);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "OriginId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            // 
            // OriginName
            // 
            this.OriginName.DataPropertyName = "OriginName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OriginName.DefaultCellStyle = dataGridViewCellStyle2;
            this.OriginName.HeaderText = "نام";
            this.OriginName.Name = "OriginName";
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Update.DefaultCellStyle = dataGridViewCellStyle4;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "ویرایش";
            this.Update.Name = "Update";
            this.Update.Text = "ویرایش";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // OriginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(465, 692);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.txtOriginName);
            this.Controls.Add(this.btnOriginExit);
            this.Controls.Add(this.btnOriginEdit);
            this.Controls.Add(this.grdOrigin);
            this.Controls.Add(this.btnOriginAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOriginID);
            this.Controls.Add(this.شناسه);
            this.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OriginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مبدا";
            this.Load += new System.EventHandler(this.OriginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrigin)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrigin;
        private System.Windows.Forms.Button btnOriginAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOriginID;
        private System.Windows.Forms.Label شناسه;
        private System.Windows.Forms.TextBox txtSearchOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOriginExit;
        private System.Windows.Forms.Button btnOriginEdit;
        private TextBox txtOriginName;
        private Panel pnlSearch;
        private Button btnSearch;
        private Button btnExit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OriginName;
        private DataGridViewButtonColumn Remove;
        private DataGridViewButtonColumn Update;

        //public DataGridViewColumn OriginName { get; private set; }
    }
}