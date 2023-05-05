namespace Taxi_cervice
{
    partial class DriverForm
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
            this.btnDriverAdd = new System.Windows.Forms.Button();
            this.txtDriverAdress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDriverMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDriverTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDriverFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdDriver = new System.Windows.Forms.DataGridView();
            this.DriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPictuer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DEletePictuer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDriverCancel = new System.Windows.Forms.Button();
            this.btnDriverEdit = new System.Windows.Forms.Button();
            this.txtSearchDriverLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDriverLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearchDriverFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDriverInformation = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.driverPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDriver)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlDriverInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDriverAdd
            // 
            this.btnDriverAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDriverAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverAdd.Location = new System.Drawing.Point(221, 233);
            this.btnDriverAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDriverAdd.Name = "btnDriverAdd";
            this.btnDriverAdd.Size = new System.Drawing.Size(112, 35);
            this.btnDriverAdd.TabIndex = 0;
            this.btnDriverAdd.Text = "افزودن";
            this.btnDriverAdd.UseVisualStyleBackColor = false;
            this.btnDriverAdd.Click += new System.EventHandler(this.txtDriverAdd_Click);
            // 
            // txtDriverAdress
            // 
            this.txtDriverAdress.Location = new System.Drawing.Point(151, 76);
            this.txtDriverAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverAdress.Name = "txtDriverAdress";
            this.txtDriverAdress.Size = new System.Drawing.Size(488, 64);
            this.txtDriverAdress.TabIndex = 5;
            this.txtDriverAdress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "آدرس : ";
            // 
            // txtDriverMobile
            // 
            this.txtDriverMobile.Location = new System.Drawing.Point(250, 42);
            this.txtDriverMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverMobile.Name = "txtDriverMobile";
            this.txtDriverMobile.Size = new System.Drawing.Size(148, 27);
            this.txtDriverMobile.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "شماره موبایل :";
            // 
            // txtDriverTel
            // 
            this.txtDriverTel.Location = new System.Drawing.Point(6, 45);
            this.txtDriverTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverTel.Name = "txtDriverTel";
            this.txtDriverTel.Size = new System.Drawing.Size(146, 27);
            this.txtDriverTel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "شماره تلفن :";
            // 
            // txtDriverFirstName
            // 
            this.txtDriverFirstName.Location = new System.Drawing.Point(250, 11);
            this.txtDriverFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverFirstName.Name = "txtDriverFirstName";
            this.txtDriverFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDriverFirstName.Size = new System.Drawing.Size(148, 27);
            this.txtDriverFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "نام :";
            // 
            // txtDriverID
            // 
            this.txtDriverID.Location = new System.Drawing.Point(491, 7);
            this.txtDriverID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.ReadOnly = true;
            this.txtDriverID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDriverID.Size = new System.Drawing.Size(148, 27);
            this.txtDriverID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "شناسه راننده : ";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(491, 42);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalCode.Size = new System.Drawing.Size(148, 27);
            this.txtNationalCode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "کد ملی :";
            // 
            // grdDriver
            // 
            this.grdDriver.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverId,
            this.DriverName,
            this.LastName,
            this.DriverMobile,
            this.DriverPictuer,
            this.Remove,
            this.DEletePictuer,
            this.Update});
            this.grdDriver.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grdDriver.Location = new System.Drawing.Point(1, 274);
            this.grdDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdDriver.Name = "grdDriver";
            this.grdDriver.Size = new System.Drawing.Size(892, 410);
            this.grdDriver.TabIndex = 34;
            this.grdDriver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDriver_CellContentClick);
            // 
            // DriverId
            // 
            this.DriverId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverId.DataPropertyName = "DriverId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DriverId.DefaultCellStyle = dataGridViewCellStyle1;
            this.DriverId.FillWeight = 120F;
            this.DriverId.HeaderText = "شناسه راننده";
            this.DriverId.Name = "DriverId";
            // 
            // DriverName
            // 
            this.DriverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverName.DataPropertyName = "DriverFirstName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DriverName.DefaultCellStyle = dataGridViewCellStyle2;
            this.DriverName.FillWeight = 120F;
            this.DriverName.HeaderText = "نام ";
            this.DriverName.Name = "DriverName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "DriverLastName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LastName.DefaultCellStyle = dataGridViewCellStyle3;
            this.LastName.FillWeight = 120F;
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            // 
            // DriverMobile
            // 
            this.DriverMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverMobile.DataPropertyName = "DriverMobile";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DriverMobile.DefaultCellStyle = dataGridViewCellStyle4;
            this.DriverMobile.FillWeight = 120F;
            this.DriverMobile.HeaderText = "موبایل";
            this.DriverMobile.Name = "DriverMobile";
            // 
            // DriverPictuer
            // 
            this.DriverPictuer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DriverPictuer.DefaultCellStyle = dataGridViewCellStyle5;
            this.DriverPictuer.FillWeight = 120F;
            this.DriverPictuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverPictuer.HeaderText = "تصویر راننده";
            this.DriverPictuer.Name = "DriverPictuer";
            this.DriverPictuer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DriverPictuer.Text = "تصویر راننده";
            this.DriverPictuer.UseColumnTextForButtonValue = true;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Remove.DefaultCellStyle = dataGridViewCellStyle6;
            this.Remove.FillWeight = 120F;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.HeaderText = "حذف";
            this.Remove.Name = "Remove";
            this.Remove.Text = "حذف";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // DEletePictuer
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.DEletePictuer.DefaultCellStyle = dataGridViewCellStyle7;
            this.DEletePictuer.FillWeight = 120F;
            this.DEletePictuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DEletePictuer.HeaderText = "حذف تصویر";
            this.DEletePictuer.Name = "DEletePictuer";
            this.DEletePictuer.Text = "حذف تصویر";
            this.DEletePictuer.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Update.DefaultCellStyle = dataGridViewCellStyle8;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.HeaderText = "ویرایش";
            this.Update.Name = "Update";
            this.Update.Text = "ویرایش";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // btnDriverCancel
            // 
            this.btnDriverCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDriverCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverCancel.Location = new System.Drawing.Point(461, 233);
            this.btnDriverCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDriverCancel.Name = "btnDriverCancel";
            this.btnDriverCancel.Size = new System.Drawing.Size(112, 35);
            this.btnDriverCancel.TabIndex = 1;
            this.btnDriverCancel.Text = "بازگشت";
            this.btnDriverCancel.UseVisualStyleBackColor = false;
            this.btnDriverCancel.Click += new System.EventHandler(this.btnDriverCancel_Click);
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDriverEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriverEdit.Location = new System.Drawing.Point(341, 234);
            this.btnDriverEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(112, 35);
            this.btnDriverEdit.TabIndex = 36;
            this.btnDriverEdit.Text = "ثبت تغییرات";
            this.btnDriverEdit.UseVisualStyleBackColor = false;
            this.btnDriverEdit.Click += new System.EventHandler(this.btnDriverEdit_Click);
            // 
            // txtSearchDriverLastName
            // 
            this.txtSearchDriverLastName.Location = new System.Drawing.Point(144, 6);
            this.txtSearchDriverLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchDriverLastName.Name = "txtSearchDriverLastName";
            this.txtSearchDriverLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchDriverLastName.Size = new System.Drawing.Size(148, 27);
            this.txtSearchDriverLastName.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(587, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "جست و جو بر اساس  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "فامیلی راننده";
            // 
            // txtDriverLastName
            // 
            this.txtDriverLastName.Location = new System.Drawing.Point(4, 8);
            this.txtDriverLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverLastName.Name = "txtDriverLastName";
            this.txtDriverLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDriverLastName.Size = new System.Drawing.Size(148, 27);
            this.txtDriverLastName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "نام خانوادگی :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(24, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 29);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.txtSearchDriverFirstName);
            this.pnlSearch.Controls.Add(this.label7);
            this.pnlSearch.Controls.Add(this.txtSearchDriverLastName);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Location = new System.Drawing.Point(90, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(707, 47);
            this.pnlSearch.TabIndex = 47;
            // 
            // txtSearchDriverFirstName
            // 
            this.txtSearchDriverFirstName.Location = new System.Drawing.Point(372, 7);
            this.txtSearchDriverFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchDriverFirstName.Name = "txtSearchDriverFirstName";
            this.txtSearchDriverFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchDriverFirstName.Size = new System.Drawing.Size(148, 27);
            this.txtSearchDriverFirstName.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "نام راننده ";
            // 
            // pnlDriverInformation
            // 
            this.pnlDriverInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(175)))));
            this.pnlDriverInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDriverInformation.Controls.Add(this.txtDriverLastName);
            this.pnlDriverInformation.Controls.Add(this.label1);
            this.pnlDriverInformation.Controls.Add(this.txtDriverID);
            this.pnlDriverInformation.Controls.Add(this.label2);
            this.pnlDriverInformation.Controls.Add(this.label12);
            this.pnlDriverInformation.Controls.Add(this.txtNationalCode);
            this.pnlDriverInformation.Controls.Add(this.label5);
            this.pnlDriverInformation.Controls.Add(this.txtDriverAdress);
            this.pnlDriverInformation.Controls.Add(this.label6);
            this.pnlDriverInformation.Controls.Add(this.txtDriverFirstName);
            this.pnlDriverInformation.Controls.Add(this.label3);
            this.pnlDriverInformation.Controls.Add(this.txtDriverTel);
            this.pnlDriverInformation.Controls.Add(this.label4);
            this.pnlDriverInformation.Controls.Add(this.txtDriverMobile);
            this.pnlDriverInformation.Location = new System.Drawing.Point(12, 76);
            this.pnlDriverInformation.Name = "pnlDriverInformation";
            this.pnlDriverInformation.Size = new System.Drawing.Size(737, 151);
            this.pnlDriverInformation.TabIndex = 48;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(141)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(766, 233);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 37);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // driverPicture
            // 
            this.driverPicture.Location = new System.Drawing.Point(766, 76);
            this.driverPicture.Name = "driverPicture";
            this.driverPicture.Size = new System.Drawing.Size(117, 151);
            this.driverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.driverPicture.TabIndex = 50;
            this.driverPicture.TabStop = false;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(895, 692);
            this.Controls.Add(this.driverPicture);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlDriverInformation);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnDriverCancel);
            this.Controls.Add(this.btnDriverEdit);
            this.Controls.Add(this.grdDriver);
            this.Controls.Add(this.btnDriverAdd);
            this.Font = new System.Drawing.Font("Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DriverForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مشخصات رانندگان";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDriver)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlDriverInformation.ResumeLayout(false);
            this.pnlDriverInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDriverAdd;
        private System.Windows.Forms.RichTextBox txtDriverAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDriverMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDriverTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDriverFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdDriver;
        private System.Windows.Forms.Button btnDriverCancel;
        private System.Windows.Forms.Button btnDriverEdit;
        private System.Windows.Forms.TextBox txtSearchDriverLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDriverLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlDriverInformation;
        private System.Windows.Forms.TextBox txtSearchDriverFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox driverPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverMobile;
        private System.Windows.Forms.DataGridViewButtonColumn DriverPictuer;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewButtonColumn DEletePictuer;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}