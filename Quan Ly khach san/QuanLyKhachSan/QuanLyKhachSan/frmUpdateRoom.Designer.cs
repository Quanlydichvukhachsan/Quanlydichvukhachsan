namespace QuanLyKhachSan
{
    partial class frmUpdateRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgvRoomType = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnExitForm = new Guna.UI.WinForms.GunaButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaButton();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbMaLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSonguoiToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.txtTimKiemRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaPhongQLP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoomType)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(245, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 596);
            this.panel1.TabIndex = 0;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.AutoScroll = true;
            this.guna2GroupBox2.Controls.Add(this.dtgvRoomType);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(586, 596);
            this.guna2GroupBox2.TabIndex = 13;
            this.guna2GroupBox2.Text = "Danh sách loại phòng";
            // 
            // dtgvRoomType
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dtgvRoomType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgvRoomType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRoomType.BackgroundColor = System.Drawing.Color.White;
            this.dtgvRoomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRoomType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvRoomType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvRoomType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgvRoomType.ColumnHeadersHeight = 22;
            this.dtgvRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRoomType,
            this.NameRoomType,
            this.LimitPerson,
            this.Price});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvRoomType.DefaultCellStyle = dataGridViewCellStyle23;
            this.dtgvRoomType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvRoomType.EnableHeadersVisualStyles = false;
            this.dtgvRoomType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dtgvRoomType.Location = new System.Drawing.Point(0, 7);
            this.dtgvRoomType.Name = "dtgvRoomType";
            this.dtgvRoomType.RowHeadersVisible = false;
            this.dtgvRoomType.RowHeadersWidth = 51;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.dtgvRoomType.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dtgvRoomType.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvRoomType.RowTemplate.DividerHeight = 5;
            this.dtgvRoomType.RowTemplate.Height = 60;
            this.dtgvRoomType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRoomType.Size = new System.Drawing.Size(586, 589);
            this.dtgvRoomType.TabIndex = 5;
            this.dtgvRoomType.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvRoomType.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvRoomType.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvRoomType.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvRoomType.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvRoomType.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvRoomType.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvRoomType.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dtgvRoomType.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dtgvRoomType.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvRoomType.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvRoomType.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.dtgvRoomType.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvRoomType.ThemeStyle.HeaderStyle.Height = 22;
            this.dtgvRoomType.ThemeStyle.ReadOnly = false;
            this.dtgvRoomType.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvRoomType.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvRoomType.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvRoomType.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvRoomType.ThemeStyle.RowsStyle.Height = 60;
            this.dtgvRoomType.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvRoomType.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // IDRoomType
            // 
            this.IDRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDRoomType.DataPropertyName = "IDRoomType";
            this.IDRoomType.FillWeight = 1.573463F;
            this.IDRoomType.HeaderText = "Mã";
            this.IDRoomType.MinimumWidth = 6;
            this.IDRoomType.Name = "IDRoomType";
            this.IDRoomType.Width = 70;
            // 
            // NameRoomType
            // 
            this.NameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameRoomType.DataPropertyName = "NameRoomType";
            this.NameRoomType.FillWeight = 67.60133F;
            this.NameRoomType.HeaderText = "Tên Loại Phòng ";
            this.NameRoomType.MinimumWidth = 6;
            this.NameRoomType.Name = "NameRoomType";
            this.NameRoomType.Width = 200;
            // 
            // LimitPerson
            // 
            this.LimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LimitPerson.DataPropertyName = "LimitPerson";
            this.LimitPerson.FillWeight = 149.3056F;
            this.LimitPerson.HeaderText = "Số người tối đa";
            this.LimitPerson.MinimumWidth = 6;
            this.LimitPerson.Name = "LimitPerson";
            this.LimitPerson.Width = 150;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 90.57513F;
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.guna2GroupBox3);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 596);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2GroupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 149);
            this.panel3.TabIndex = 11;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox4.Controls.Add(this.gunaButton1);
            this.guna2GroupBox4.Controls.Add(this.btnExitForm);
            this.guna2GroupBox4.Controls.Add(this.btnCapNhat);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(245, 149);
            this.guna2GroupBox4.TabIndex = 10;
            this.guna2GroupBox4.Text = "Thông tin loại phòng";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.DarkGreen;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(29, 106);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(180, 32);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "Xóa bộ lọc";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnExitForm
            // 
            this.btnExitForm.AnimationHoverSpeed = 0.07F;
            this.btnExitForm.AnimationSpeed = 0.03F;
            this.btnExitForm.BackColor = System.Drawing.Color.Transparent;
            this.btnExitForm.BaseColor = System.Drawing.Color.White;
            this.btnExitForm.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnExitForm.BorderSize = 1;
            this.btnExitForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExitForm.FocusedColor = System.Drawing.Color.Empty;
            this.btnExitForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitForm.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExitForm.Image = null;
            this.btnExitForm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExitForm.Location = new System.Drawing.Point(27, 157);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExitForm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExitForm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExitForm.OnHoverImage = null;
            this.btnExitForm.OnPressedColor = System.Drawing.Color.Black;
            this.btnExitForm.Radius = 15;
            this.btnExitForm.Size = new System.Drawing.Size(182, 32);
            this.btnExitForm.TabIndex = 7;
            this.btnExitForm.Text = "Đóng";
            this.btnExitForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.White;
            this.btnCapNhat.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCapNhat.BorderSize = 1;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCapNhat.Image = null;
            this.btnCapNhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhat.Location = new System.Drawing.Point(27, 55);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 15;
            this.btnCapNhat.Size = new System.Drawing.Size(182, 32);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox3.Controls.Add(this.cbbMaLoaiPhong);
            this.guna2GroupBox3.Controls.Add(this.label1);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.Controls.Add(this.txtGiaPhong);
            this.guna2GroupBox3.Controls.Add(this.txtSonguoiToiDa);
            this.guna2GroupBox3.Controls.Add(this.txtTenPhong);
            this.guna2GroupBox3.Controls.Add(this.label2);
            this.guna2GroupBox3.Controls.Add(this.label12);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 159);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(245, 288);
            this.guna2GroupBox3.TabIndex = 10;
            this.guna2GroupBox3.Text = "Thông tin loại phòng";
            // 
            // cbbMaLoaiPhong
            // 
            this.cbbMaLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaLoaiPhong.FocusedState.Parent = this.cbbMaLoaiPhong;
            this.cbbMaLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaLoaiPhong.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbbMaLoaiPhong.HoverState.Parent = this.cbbMaLoaiPhong;
            this.cbbMaLoaiPhong.ItemHeight = 30;
            this.cbbMaLoaiPhong.ItemsAppearance.Parent = this.cbbMaLoaiPhong;
            this.cbbMaLoaiPhong.Location = new System.Drawing.Point(25, 68);
            this.cbbMaLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaLoaiPhong.Name = "cbbMaLoaiPhong";
            this.cbbMaLoaiPhong.ShadowDecoration.Parent = this.cbbMaLoaiPhong;
            this.cbbMaLoaiPhong.Size = new System.Drawing.Size(200, 36);
            this.cbbMaLoaiPhong.TabIndex = 19;
            this.cbbMaLoaiPhong.SelectedValueChanged += new System.EventHandler(this.cbbMaLoaiPhong_SelectedValueChanged);
            this.cbbMaLoaiPhong.Click += new System.EventHandler(this.cbbMaLoaiPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(24, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giá phòng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(22, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số người tối đa";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaPhong.DefaultText = "";
            this.txtGiaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhong.DisabledState.Parent = this.txtGiaPhong;
            this.txtGiaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhong.FocusedState.Parent = this.txtGiaPhong;
            this.txtGiaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaPhong.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtGiaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhong.HoverState.Parent = this.txtGiaPhong;
            this.txtGiaPhong.Location = new System.Drawing.Point(25, 240);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.PasswordChar = '\0';
            this.txtGiaPhong.PlaceholderText = "";
            this.txtGiaPhong.SelectedText = "";
            this.txtGiaPhong.ShadowDecoration.Parent = this.txtGiaPhong;
            this.txtGiaPhong.Size = new System.Drawing.Size(200, 29);
            this.txtGiaPhong.TabIndex = 17;
            // 
            // txtSonguoiToiDa
            // 
            this.txtSonguoiToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSonguoiToiDa.DefaultText = "";
            this.txtSonguoiToiDa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSonguoiToiDa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSonguoiToiDa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSonguoiToiDa.DisabledState.Parent = this.txtSonguoiToiDa;
            this.txtSonguoiToiDa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSonguoiToiDa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSonguoiToiDa.FocusedState.Parent = this.txtSonguoiToiDa;
            this.txtSonguoiToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSonguoiToiDa.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSonguoiToiDa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSonguoiToiDa.HoverState.Parent = this.txtSonguoiToiDa;
            this.txtSonguoiToiDa.Location = new System.Drawing.Point(23, 185);
            this.txtSonguoiToiDa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSonguoiToiDa.Name = "txtSonguoiToiDa";
            this.txtSonguoiToiDa.PasswordChar = '\0';
            this.txtSonguoiToiDa.PlaceholderText = "";
            this.txtSonguoiToiDa.SelectedText = "";
            this.txtSonguoiToiDa.ShadowDecoration.Parent = this.txtSonguoiToiDa;
            this.txtSonguoiToiDa.Size = new System.Drawing.Size(200, 29);
            this.txtSonguoiToiDa.TabIndex = 17;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPhong.DefaultText = "";
            this.txtTenPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenPhong.DisabledState.Parent = this.txtTenPhong;
            this.txtTenPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPhong.FocusedState.Parent = this.txtTenPhong;
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenPhong.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTenPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPhong.HoverState.Parent = this.txtTenPhong;
            this.txtTenPhong.Location = new System.Drawing.Point(25, 127);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.PasswordChar = '\0';
            this.txtTenPhong.PlaceholderText = "";
            this.txtTenPhong.SelectedText = "";
            this.txtTenPhong.ShadowDecoration.Parent = this.txtTenPhong;
            this.txtTenPhong.Size = new System.Drawing.Size(200, 29);
            this.txtTenPhong.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên loại phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(22, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã phòng";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Controls.Add(this.btnTimKiem);
            this.guna2GroupBox1.Controls.Add(this.txtTimKiemRoom);
            this.guna2GroupBox1.Controls.Add(this.lblMaPhongQLP);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(245, 159);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.White;
            this.btnTimKiem.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiem.BorderSize = 1;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiem.Image = null;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.Location = new System.Drawing.Point(25, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 15;
            this.btnTimKiem.Size = new System.Drawing.Size(182, 32);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemRoom
            // 
            this.txtTimKiemRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemRoom.DefaultText = "";
            this.txtTimKiemRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemRoom.DisabledState.Parent = this.txtTimKiemRoom;
            this.txtTimKiemRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemRoom.FocusedState.Parent = this.txtTimKiemRoom;
            this.txtTimKiemRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemRoom.HoverState.Parent = this.txtTimKiemRoom;
            this.txtTimKiemRoom.Location = new System.Drawing.Point(25, 61);
            this.txtTimKiemRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiemRoom.Name = "txtTimKiemRoom";
            this.txtTimKiemRoom.PasswordChar = '\0';
            this.txtTimKiemRoom.PlaceholderText = "";
            this.txtTimKiemRoom.SelectedText = "";
            this.txtTimKiemRoom.ShadowDecoration.Parent = this.txtTimKiemRoom;
            this.txtTimKiemRoom.Size = new System.Drawing.Size(192, 29);
            this.txtTimKiemRoom.TabIndex = 2;
            // 
            // lblMaPhongQLP
            // 
            this.lblMaPhongQLP.AutoSize = true;
            this.lblMaPhongQLP.BackColor = System.Drawing.Color.White;
            this.lblMaPhongQLP.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaPhongQLP.Location = new System.Drawing.Point(22, 41);
            this.lblMaPhongQLP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPhongQLP.Name = "lblMaPhongQLP";
            this.lblMaPhongQLP.Size = new System.Drawing.Size(89, 15);
            this.lblMaPhongQLP.TabIndex = 2;
            this.lblMaPhongQLP.Text = "Mã /Tên phòng";
            // 
            // frmUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateRoom";
            this.Text = "frmUpdateRoom";
            this.Load += new System.EventHandler(this.frmUpdateRoom_Load);
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoomType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvRoomType;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemRoom;
        private System.Windows.Forms.Label lblMaPhongQLP;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaLoaiPhong;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtSonguoiToiDa;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI.WinForms.GunaButton btnExitForm;
        private Guna.UI.WinForms.GunaButton btnCapNhat;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}