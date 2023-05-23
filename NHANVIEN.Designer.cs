namespace GUI_STORE
{
    partial class NHANVIEN
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
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGT = new System.Windows.Forms.ComboBox();
            this.DTPNV = new System.Windows.Forms.DateTimePicker();
            this.cbxLNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lb05 = new System.Windows.Forms.Label();
            this.lb04 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lb06 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AllowUserToOrderColumns = true;
            this.dgvNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.GIOITNH,
            this.NGAYSINH,
            this.DIACHI,
            this.DIENTHOAI,
            this.LOAINV,
            this.NGLV,
            this.TENDN,
            this.MATKHAU});
            this.dgvNhanvien.EnableHeadersVisualStyles = false;
            this.dgvNhanvien.GridColor = System.Drawing.Color.Teal;
            this.dgvNhanvien.Location = new System.Drawing.Point(12, 307);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            this.dgvNhanvien.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanvien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(1486, 529);
            this.dgvNhanvien.TabIndex = 9;
            this.dgvNhanvien.Click += new System.EventHandler(this.dgvNhanvien_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtMK);
            this.panel4.Controls.Add(this.txtDN);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbxGT);
            this.panel4.Controls.Add(this.DTPNV);
            this.panel4.Controls.Add(this.cbxLNV);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.btEdit);
            this.panel4.Controls.Add(this.btDel);
            this.panel4.Controls.Add(this.btAdd);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.txtTenNV);
            this.panel4.Controls.Add(this.txtMaNV);
            this.panel4.Controls.Add(this.lb05);
            this.panel4.Controls.Add(this.lb04);
            this.panel4.Controls.Add(this.lbl03);
            this.panel4.Controls.Add(this.lb06);
            this.panel4.Controls.Add(this.lbl02);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(68, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1375, 253);
            this.panel4.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 28);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 89;
            this.label6.Text = "Ngày làm việc";
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(927, 160);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(177, 30);
            this.txtMK.TabIndex = 86;
            // 
            // txtDN
            // 
            this.txtDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDN.Location = new System.Drawing.Point(555, 162);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(177, 30);
            this.txtDN.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(811, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 88;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(382, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tên Đăng nhập";
            // 
            // cbxGT
            // 
            this.cbxGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGT.FormattingEnabled = true;
            this.cbxGT.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.cbxGT.Location = new System.Drawing.Point(927, 67);
            this.cbxGT.Name = "cbxGT";
            this.cbxGT.Size = new System.Drawing.Size(128, 30);
            this.cbxGT.TabIndex = 84;
            // 
            // DTPNV
            // 
            this.DTPNV.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNV.CustomFormat = "";
            this.DTPNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPNV.Location = new System.Drawing.Point(1233, 62);
            this.DTPNV.Name = "DTPNV";
            this.DTPNV.Size = new System.Drawing.Size(128, 28);
            this.DTPNV.TabIndex = 83;
            // 
            // cbxLNV
            // 
            this.cbxLNV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLNV.FormattingEnabled = true;
            this.cbxLNV.Items.AddRange(new object[] {
            "TỔNG GIÁM ĐỐC",
            "PHÓ GIÁM ĐỐC",
            "TRƯỞNG PHÒNG",
            "NHÂN VIÊN",
            "QUẢN LÝ NHÂN SỰ",
            "QUẢN LÝ KHO HÀNG"});
            this.cbxLNV.Location = new System.Drawing.Point(927, 114);
            this.cbxLNV.Name = "cbxLNV";
            this.cbxLNV.Size = new System.Drawing.Size(236, 33);
            this.cbxLNV.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(811, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 81;
            this.label1.Text = "Loại NV";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1241, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 79;
            this.button1.Text = "Khởi tạo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(555, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(170, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Teal;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(1101, 206);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(120, 38);
            this.btEdit.TabIndex = 77;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Teal;
            this.btDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Location = new System.Drawing.Point(957, 206);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(119, 39);
            this.btDel.TabIndex = 76;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Teal;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(816, 205);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 39);
            this.btAdd.TabIndex = 75;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(164, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 30);
            this.txtAddress.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(555, 63);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(219, 30);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(164, 63);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(92, 30);
            this.txtMaNV.TabIndex = 0;
            // 
            // lb05
            // 
            this.lb05.AutoSize = true;
            this.lb05.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb05.ForeColor = System.Drawing.Color.White;
            this.lb05.Location = new System.Drawing.Point(382, 111);
            this.lb05.Name = "lb05";
            this.lb05.Size = new System.Drawing.Size(128, 28);
            this.lb05.TabIndex = 76;
            this.lb05.Text = "Số điện thoại";
            // 
            // lb04
            // 
            this.lb04.AutoSize = true;
            this.lb04.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb04.ForeColor = System.Drawing.Color.White;
            this.lb04.Location = new System.Drawing.Point(16, 114);
            this.lb04.Name = "lb04";
            this.lb04.Size = new System.Drawing.Size(71, 28);
            this.lb04.TabIndex = 75;
            this.lb04.Text = "Địa chỉ";
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.ForeColor = System.Drawing.Color.White;
            this.lbl03.Location = new System.Drawing.Point(1119, 62);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(99, 28);
            this.lbl03.TabIndex = 73;
            this.lbl03.Text = "Ngày sinh";
            // 
            // lb06
            // 
            this.lb06.AutoSize = true;
            this.lb06.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb06.ForeColor = System.Drawing.Color.White;
            this.lb06.Location = new System.Drawing.Point(811, 67);
            this.lb06.Name = "lb06";
            this.lb06.Size = new System.Drawing.Size(87, 28);
            this.lb06.TabIndex = 73;
            this.lb06.Text = "Giới tính";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.ForeColor = System.Drawing.Color.White;
            this.lbl02.Location = new System.Drawing.Point(380, 65);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(130, 28);
            this.lbl02.TabIndex = 72;
            this.lbl02.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mã nhân viên";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1374, 41);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(551, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Tin Nhân viên";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.FillWeight = 70F;
            this.MANV.HeaderText = "MÃ NHÂN VIÊN";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNV.DataPropertyName = "HOTENNV";
            this.TENNV.FillWeight = 150F;
            this.TENNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // GIOITNH
            // 
            this.GIOITNH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITNH.DataPropertyName = "GIOITINH";
            this.GIOITNH.FillWeight = 70F;
            this.GIOITNH.HeaderText = "GIỚI TÍNH";
            this.GIOITNH.MinimumWidth = 6;
            this.GIOITNH.Name = "GIOITNH";
            this.GIOITNH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "NGÀY SINH";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "SỐ ĐIỆN THOẠI";
            this.DIENTHOAI.MinimumWidth = 6;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.ReadOnly = true;
            // 
            // LOAINV
            // 
            this.LOAINV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOAINV.DataPropertyName = "TENLOAINV";
            this.LOAINV.HeaderText = "LOẠI NHÂN VIÊN";
            this.LOAINV.MinimumWidth = 6;
            this.LOAINV.Name = "LOAINV";
            this.LOAINV.ReadOnly = true;
            // 
            // NGLV
            // 
            this.NGLV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGLV.DataPropertyName = "NGAYVL";
            this.NGLV.FillWeight = 80F;
            this.NGLV.HeaderText = "NGÀY VIỆC LÀM";
            this.NGLV.MinimumWidth = 6;
            this.NGLV.Name = "NGLV";
            this.NGLV.ReadOnly = true;
            // 
            // TENDN
            // 
            this.TENDN.DataPropertyName = "TENDN";
            this.TENDN.HeaderText = "TÊN ĐĂNG NHẬP";
            this.TENDN.MinimumWidth = 6;
            this.TENDN.Name = "TENDN";
            this.TENDN.ReadOnly = true;
            this.TENDN.Width = 125;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "MẬT KHẨU";
            this.MATKHAU.MinimumWidth = 6;
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Width = 125;
            // 
            // NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1510, 874);
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.panel4);
            this.Name = "NHANVIEN";
            this.Text = "NHANVIEN";
            this.Load += new System.EventHandler(this.NHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxGT;
        private System.Windows.Forms.DateTimePicker DTPNV;
        private System.Windows.Forms.ComboBox cbxLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lb05;
        private System.Windows.Forms.Label lb04;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lb06;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
    }
}