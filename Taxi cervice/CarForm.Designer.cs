
namespace Taxi_cervice
{
    partial class CarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.grdCar = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModelYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumberPlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearchCarColor = new System.Windows.Forms.TextBox();
            this.txtSeachCarModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarModelYear = new System.Windows.Forms.TextBox();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarNumberPlate = new System.Windows.Forms.TextBox();
            this.pnlCarInformation = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCar)).BeginInit();
            this.pnlCarInformation.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "شناسه خودرو :";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(105, 44);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.ReadOnly = true;
            this.txtCarID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarID.Size = new System.Drawing.Size(56, 27);
            this.txtCarID.TabIndex = 0;
            this.txtCarID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grdCar
            // 
            this.grdCar.BackgroundColor = System.Drawing.Color.White;
            this.grdCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.CarMake,
            this.CarModel,
            this.CarModelYear,
            this.CarColor,
            this.CarNumberPlate,
            this.Delete,
            this.Edit});
            this.grdCar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grdCar.Location = new System.Drawing.Point(9, 212);
            this.grdCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdCar.Name = "grdCar";
            this.grdCar.Size = new System.Drawing.Size(860, 516);
            this.grdCar.TabIndex = 11;
            this.grdCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCar_CellContentClick);
            // 
            // CarID
            // 
            this.CarID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CarID.DataPropertyName = "CarID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarID.DefaultCellStyle = dataGridViewCellStyle1;
            this.CarID.Frozen = true;
            this.CarID.HeaderText = "شناسه خودرو";
            this.CarID.Name = "CarID";
            // 
            // CarMake
            // 
            this.CarMake.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarMake.DataPropertyName = "CarMake";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarMake.DefaultCellStyle = dataGridViewCellStyle2;
            this.CarMake.FillWeight = 120F;
            this.CarMake.HeaderText = "شرکت سازنده";
            this.CarMake.Name = "CarMake";
            // 
            // CarModel
            // 
            this.CarModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarModel.DataPropertyName = "CarModel";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarModel.DefaultCellStyle = dataGridViewCellStyle3;
            this.CarModel.HeaderText = "مدل خودرو";
            this.CarModel.Name = "CarModel";
            // 
            // CarModelYear
            // 
            this.CarModelYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarModelYear.DataPropertyName = "CarModelYear";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarModelYear.DefaultCellStyle = dataGridViewCellStyle4;
            this.CarModelYear.HeaderText = "سال تولید ";
            this.CarModelYear.Name = "CarModelYear";
            // 
            // CarColor
            // 
            this.CarColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarColor.DataPropertyName = "CarColor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarColor.DefaultCellStyle = dataGridViewCellStyle5;
            this.CarColor.HeaderText = "رنگ";
            this.CarColor.Name = "CarColor";
            // 
            // CarNumberPlate
            // 
            this.CarNumberPlate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarNumberPlate.DataPropertyName = "CarNumberPlate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CarNumberPlate.DefaultCellStyle = dataGridViewCellStyle6;
            this.CarNumberPlate.HeaderText = "پلاک";
            this.CarNumberPlate.Name = "CarNumberPlate";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "حذف";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "حذف";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.DataPropertyName = "Edit";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle8;
            this.Edit.FillWeight = 120F;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "ویرایش";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "ویرایش";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(770, 99);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(770, 55);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "ثبت تغییرات";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(770, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearchCarColor
            // 
            this.txtSearchCarColor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSearchCarColor.Location = new System.Drawing.Point(104, 16);
            this.txtSearchCarColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCarColor.Name = "txtSearchCarColor";
            this.txtSearchCarColor.Size = new System.Drawing.Size(108, 27);
            this.txtSearchCarColor.TabIndex = 9;
            this.txtSearchCarColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeachCarModel
            // 
            this.txtSeachCarModel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSeachCarModel.Location = new System.Drawing.Point(333, 16);
            this.txtSeachCarModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeachCarModel.Name = "txtSeachCarModel";
            this.txtSeachCarModel.Size = new System.Drawing.Size(105, 27);
            this.txtSeachCarModel.TabIndex = 10;
            this.txtSeachCarModel.Tag = "لفبا";
            this.txtSeachCarModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "شرکت سازنده :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "رنگ : ";
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(483, 18);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(148, 27);
            this.txtCarMake.TabIndex = 5;
            this.txtCarMake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "مدل : ";
            // 
            // txtCarModel
            // 
            this.txtCarModel.BackColor = System.Drawing.Color.White;
            this.txtCarModel.Location = new System.Drawing.Point(231, 18);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(148, 27);
            this.txtCarModel.TabIndex = 6;
            this.txtCarModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "سال تولید : ";
            // 
            // txtCarModelYear
            // 
            this.txtCarModelYear.Location = new System.Drawing.Point(16, 18);
            this.txtCarModelYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarModelYear.Name = "txtCarModelYear";
            this.txtCarModelYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarModelYear.Size = new System.Drawing.Size(148, 27);
            this.txtCarModelYear.TabIndex = 7;
            this.txtCarModelYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(483, 71);
            this.txtCarColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(148, 27);
            this.txtCarColor.TabIndex = 8;
            this.txtCarColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "پلاک خودرو : ";
            // 
            // txtCarNumberPlate
            // 
            this.txtCarNumberPlate.Location = new System.Drawing.Point(122, 71);
            this.txtCarNumberPlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarNumberPlate.Name = "txtCarNumberPlate";
            this.txtCarNumberPlate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarNumberPlate.Size = new System.Drawing.Size(257, 27);
            this.txtCarNumberPlate.TabIndex = 9;
            this.txtCarNumberPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCarInformation
            // 
            this.pnlCarInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.pnlCarInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCarInformation.Controls.Add(this.txtCarNumberPlate);
            this.pnlCarInformation.Controls.Add(this.label6);
            this.pnlCarInformation.Controls.Add(this.txtCarColor);
            this.pnlCarInformation.Controls.Add(this.txtCarModelYear);
            this.pnlCarInformation.Controls.Add(this.label4);
            this.pnlCarInformation.Controls.Add(this.txtCarModel);
            this.pnlCarInformation.Controls.Add(this.label3);
            this.pnlCarInformation.Controls.Add(this.txtCarMake);
            this.pnlCarInformation.Controls.Add(this.label5);
            this.pnlCarInformation.Controls.Add(this.label2);
            this.pnlCarInformation.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlCarInformation.Location = new System.Drawing.Point(20, 81);
            this.pnlCarInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCarInformation.Name = "pnlCarInformation";
            this.pnlCarInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlCarInformation.Size = new System.Drawing.Size(733, 121);
            this.pnlCarInformation.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(14, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 27);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.label8);
            this.pnlSearch.Controls.Add(this.label7);
            this.pnlSearch.Controls.Add(this.txtSearchCarColor);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSeachCarModel);
            this.pnlSearch.Location = new System.Drawing.Point(168, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(567, 61);
            this.pnlSearch.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "بر اساس رنگ خودرو :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "بر اساس مدل خودرو :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(141)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(770, 169);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 33);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(882, 779);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlCarInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdCar);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "خودرو";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCar)).EndInit();
            this.pnlCarInformation.ResumeLayout(false);
            this.pnlCarInformation.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.DataGridView grdCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearchCarColor;
        private System.Windows.Forms.TextBox txtSeachCarModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarModelYear;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarNumberPlate;
        private System.Windows.Forms.Panel pnlCarInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModelYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumberPlate;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}