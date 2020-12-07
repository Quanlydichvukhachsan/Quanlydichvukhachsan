namespace QuanLyKhachSan
{
    partial class frmUpdateCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoVaTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbQuocTich = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnluuthaydoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.cbLoaiKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cập nhật thông tin khách hàng";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Controls.Add(this.btnDong);
            this.guna2GroupBox1.Controls.Add(this.btnluuthaydoi);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.cbQuocTich);
            this.guna2GroupBox1.Controls.Add(this.cbLoaiKhachHang);
            this.guna2GroupBox1.Controls.Add(this.cbGioiTinh);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.dtpNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label16);
            this.guna2GroupBox1.Controls.Add(this.label18);
            this.guna2GroupBox1.Controls.Add(this.txtSDT);
            this.guna2GroupBox1.Controls.Add(this.txtHoVaTen);
            this.guna2GroupBox1.Controls.Add(this.txtDiaChi);
            this.guna2GroupBox1.Controls.Add(this.txtCMND);
            this.guna2GroupBox1.Controls.Add(this.label14);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 58);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(529, 445);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Thông Tin khách hàng";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CheckedState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.DarkGreen;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.ForeColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaySinh.HoverState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Location = new System.Drawing.Point(274, 81);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShadowDecoration.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Size = new System.Drawing.Size(230, 29);
            this.dtpNgaySinh.TabIndex = 26;
            this.dtpNgaySinh.Value = new System.DateTime(2020, 11, 26, 20, 52, 10, 211);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(272, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quốc tịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(271, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Địa chỉ :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(7, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Loại khách hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.ForeColor = System.Drawing.Color.DarkGreen;
            this.label18.Location = new System.Drawing.Point(5, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(10, 311);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(230, 29);
            this.txtSDT.TabIndex = 21;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoVaTen.DefaultText = "";
            this.txtHoVaTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoVaTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoVaTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTen.DisabledState.Parent = this.txtHoVaTen;
            this.txtHoVaTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTen.FocusedState.Parent = this.txtHoVaTen;
            this.txtHoVaTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoVaTen.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtHoVaTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTen.HoverState.Parent = this.txtHoVaTen;
            this.txtHoVaTen.Location = new System.Drawing.Point(8, 81);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.PasswordChar = '\0';
            this.txtHoVaTen.PlaceholderText = "";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.SelectedText = "";
            this.txtHoVaTen.ShadowDecoration.Parent = this.txtHoVaTen;
            this.txtHoVaTen.Size = new System.Drawing.Size(230, 29);
            this.txtHoVaTen.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(274, 149);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(230, 29);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtCMND
            // 
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.DefaultText = "";
            this.txtCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.DisabledState.Parent = this.txtCMND;
            this.txtCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.FocusedState.Parent = this.txtCMND;
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCMND.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.HoverState.Parent = this.txtCMND;
            this.txtCMND.Location = new System.Drawing.Point(8, 149);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.SelectedText = "";
            this.txtCMND.ShadowDecoration.Parent = this.txtCMND;
            this.txtCMND.Size = new System.Drawing.Size(230, 29);
            this.txtCMND.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(5, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Thẻ căn cước/CMND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(8, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Họ và tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 53);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(271, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày sinh";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.FocusedState.Parent = this.cbGioiTinh;
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGioiTinh.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbGioiTinh.HoverState.Parent = this.cbGioiTinh;
            this.cbGioiTinh.ItemHeight = 30;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.ItemsAppearance.Parent = this.cbGioiTinh;
            this.cbGioiTinh.Location = new System.Drawing.Point(273, 231);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.ShadowDecoration.Parent = this.cbGioiTinh;
            this.cbGioiTinh.Size = new System.Drawing.Size(232, 36);
            this.cbGioiTinh.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(271, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giới tính";
            // 
            // cbQuocTich
            // 
            this.cbQuocTich.BackColor = System.Drawing.Color.Transparent;
            this.cbQuocTich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuocTich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuocTich.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuocTich.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuocTich.FocusedState.Parent = this.cbQuocTich;
            this.cbQuocTich.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbQuocTich.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbQuocTich.HoverState.Parent = this.cbQuocTich;
            this.cbQuocTich.ItemHeight = 30;
            this.cbQuocTich.ItemsAppearance.Parent = this.cbQuocTich;
            this.cbQuocTich.Location = new System.Drawing.Point(272, 311);
            this.cbQuocTich.Margin = new System.Windows.Forms.Padding(2);
            this.cbQuocTich.Name = "cbQuocTich";
            this.cbQuocTich.ShadowDecoration.Parent = this.cbQuocTich;
            this.cbQuocTich.Size = new System.Drawing.Size(232, 36);
            this.cbQuocTich.TabIndex = 28;
            // 
            // btnluuthaydoi
            // 
            this.btnluuthaydoi.CheckedState.Parent = this.btnluuthaydoi;
            this.btnluuthaydoi.CustomImages.Parent = this.btnluuthaydoi;
            this.btnluuthaydoi.FillColor = System.Drawing.Color.DarkGreen;
            this.btnluuthaydoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnluuthaydoi.ForeColor = System.Drawing.Color.White;
            this.btnluuthaydoi.HoverState.Parent = this.btnluuthaydoi;
            this.btnluuthaydoi.Location = new System.Drawing.Point(8, 366);
            this.btnluuthaydoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnluuthaydoi.Name = "btnluuthaydoi";
            this.btnluuthaydoi.ShadowDecoration.Parent = this.btnluuthaydoi;
            this.btnluuthaydoi.Size = new System.Drawing.Size(232, 32);
            this.btnluuthaydoi.TabIndex = 30;
            this.btnluuthaydoi.Text = "Lưu Thay Đổi";
            this.btnluuthaydoi.Click += new System.EventHandler(this.btnluuthaydoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.CheckedState.Parent = this.btnDong;
            this.btnDong.CustomImages.Parent = this.btnDong;
            this.btnDong.FillColor = System.Drawing.Color.DarkGreen;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.HoverState.Parent = this.btnDong;
            this.btnDong.Location = new System.Drawing.Point(272, 366);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShadowDecoration.Parent = this.btnDong;
            this.btnDong.Size = new System.Drawing.Size(232, 32);
            this.btnDong.TabIndex = 30;
            this.btnDong.Text = "Đóng";
            // 
            // cbLoaiKhachHang
            // 
            this.cbLoaiKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiKhachHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiKhachHang.FocusedState.Parent = this.cbLoaiKhachHang;
            this.cbLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiKhachHang.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbLoaiKhachHang.HoverState.Parent = this.cbLoaiKhachHang;
            this.cbLoaiKhachHang.ItemHeight = 30;
            this.cbLoaiKhachHang.ItemsAppearance.Parent = this.cbLoaiKhachHang;
            this.cbLoaiKhachHang.Location = new System.Drawing.Point(8, 231);
            this.cbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiKhachHang.Name = "cbLoaiKhachHang";
            this.cbLoaiKhachHang.ShadowDecoration.Parent = this.cbLoaiKhachHang;
            this.cbLoaiKhachHang.Size = new System.Drawing.Size(232, 36);
            this.cbLoaiKhachHang.TabIndex = 28;
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "frmUpdateCustomer";
            this.Text = "frmUpdateCustomer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtHoVaTen;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtCMND;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbQuocTich;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinh;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2Button btnluuthaydoi;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiKhachHang;
    }
}