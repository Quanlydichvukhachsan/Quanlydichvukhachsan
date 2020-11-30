
namespace QuanLyKhachSan
{
    partial class frmQLPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgvDanhsachPhongQLP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStatusRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDongQLP = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhatPhongQLP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaPhongQLP = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemPhongQLP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbLoaiPhongQLP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatusRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbMaPhongQLP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoNguoiToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaPhongQLP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaPhongQLP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachPhongQLP)).BeginInit();
            this.panel2.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2GroupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(512, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 583);
            this.panel3.TabIndex = 11;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.AutoScroll = true;
            this.guna2GroupBox2.Controls.Add(this.dtgvDanhsachPhongQLP);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(592, 583);
            this.guna2GroupBox2.TabIndex = 12;
            this.guna2GroupBox2.Text = "Danh sách phòng";
            // 
            // dtgvDanhsachPhongQLP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDanhsachPhongQLP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhsachPhongQLP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhsachPhongQLP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDanhsachPhongQLP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDanhsachPhongQLP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDanhsachPhongQLP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvDanhsachPhongQLP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhsachPhongQLP.ColumnHeadersHeight = 22;
            this.dtgvDanhsachPhongQLP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameRoom,
            this.NameRoomType,
            this.Price,
            this.LimitPerson,
            this.nameStatusRoom});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDanhsachPhongQLP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhsachPhongQLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDanhsachPhongQLP.EnableHeadersVisualStyles = false;
            this.dtgvDanhsachPhongQLP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dtgvDanhsachPhongQLP.Location = new System.Drawing.Point(0, 41);
            this.dtgvDanhsachPhongQLP.Name = "dtgvDanhsachPhongQLP";
            this.dtgvDanhsachPhongQLP.RowHeadersVisible = false;
            this.dtgvDanhsachPhongQLP.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.dtgvDanhsachPhongQLP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDanhsachPhongQLP.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvDanhsachPhongQLP.RowTemplate.DividerHeight = 5;
            this.dtgvDanhsachPhongQLP.RowTemplate.Height = 60;
            this.dtgvDanhsachPhongQLP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhsachPhongQLP.Size = new System.Drawing.Size(592, 542);
            this.dtgvDanhsachPhongQLP.TabIndex = 4;
            this.dtgvDanhsachPhongQLP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvDanhsachPhongQLP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhsachPhongQLP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDanhsachPhongQLP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhsachPhongQLP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDanhsachPhongQLP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDanhsachPhongQLP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhsachPhongQLP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dtgvDanhsachPhongQLP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dtgvDanhsachPhongQLP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDanhsachPhongQLP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvDanhsachPhongQLP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.dtgvDanhsachPhongQLP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvDanhsachPhongQLP.ThemeStyle.HeaderStyle.Height = 22;
            this.dtgvDanhsachPhongQLP.ThemeStyle.ReadOnly = false;
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.Height = 60;
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDanhsachPhongQLP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvDanhsachPhongQLP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhsachPhongQLP_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 1.573463F;
            this.ID.HeaderText = "Mã";
            this.ID.Name = "ID";
            this.ID.Width = 47;
            // 
            // NameRoom
            // 
            this.NameRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameRoom.DataPropertyName = "NameRoom";
            this.NameRoom.FillWeight = 16.8327F;
            this.NameRoom.HeaderText = "Tên Phòng";
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.Width = 150;
            // 
            // NameRoomType
            // 
            this.NameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameRoomType.DataPropertyName = "NameRoomType";
            this.NameRoomType.FillWeight = 67.60133F;
            this.NameRoomType.HeaderText = "Loại Phòng ";
            this.NameRoomType.Name = "NameRoomType";
            this.NameRoomType.Width = 150;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 90.57513F;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            // 
            // LimitPerson
            // 
            this.LimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LimitPerson.DataPropertyName = "LimitPerson";
            this.LimitPerson.FillWeight = 149.3056F;
            this.LimitPerson.HeaderText = "Số người tối đa";
            this.LimitPerson.Name = "LimitPerson";
            this.LimitPerson.Width = 40;
            // 
            // nameStatusRoom
            // 
            this.nameStatusRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameStatusRoom.DataPropertyName = "nameStatusRoom";
            this.nameStatusRoom.FillWeight = 274.1117F;
            this.nameStatusRoom.HeaderText = "Trạng thái";
            this.nameStatusRoom.Name = "nameStatusRoom";
            this.nameStatusRoom.Width = 90;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2GroupBox4);
            this.panel2.Controls.Add(this.guna2GroupBox3);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 583);
            this.panel2.TabIndex = 3;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.btnDongQLP);
            this.guna2GroupBox4.Controls.Add(this.btnCapnhatPhongQLP);
            this.guna2GroupBox4.Controls.Add(this.btnXoaPhongQLP);
            this.guna2GroupBox4.Controls.Add(this.btnThemPhongQLP);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(0, 369);
            this.guna2GroupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(507, 214);
            this.guna2GroupBox4.TabIndex = 10;
            this.guna2GroupBox4.Text = "Chức Năng";
            // 
            // btnDongQLP
            // 
            this.btnDongQLP.CheckedState.Parent = this.btnDongQLP;
            this.btnDongQLP.CustomImages.Parent = this.btnDongQLP;
            this.btnDongQLP.FillColor = System.Drawing.Color.DarkGreen;
            this.btnDongQLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDongQLP.ForeColor = System.Drawing.Color.White;
            this.btnDongQLP.HoverState.Parent = this.btnDongQLP;
            this.btnDongQLP.Location = new System.Drawing.Point(255, 116);
            this.btnDongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongQLP.Name = "btnDongQLP";
            this.btnDongQLP.ShadowDecoration.Parent = this.btnDongQLP;
            this.btnDongQLP.Size = new System.Drawing.Size(188, 32);
            this.btnDongQLP.TabIndex = 3;
            this.btnDongQLP.Text = "Đóng";
            // 
            // btnCapnhatPhongQLP
            // 
            this.btnCapnhatPhongQLP.CheckedState.Parent = this.btnCapnhatPhongQLP;
            this.btnCapnhatPhongQLP.CustomImages.Parent = this.btnCapnhatPhongQLP;
            this.btnCapnhatPhongQLP.FillColor = System.Drawing.Color.DarkGreen;
            this.btnCapnhatPhongQLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapnhatPhongQLP.ForeColor = System.Drawing.Color.White;
            this.btnCapnhatPhongQLP.HoverState.Parent = this.btnCapnhatPhongQLP;
            this.btnCapnhatPhongQLP.Location = new System.Drawing.Point(25, 116);
            this.btnCapnhatPhongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhatPhongQLP.Name = "btnCapnhatPhongQLP";
            this.btnCapnhatPhongQLP.ShadowDecoration.Parent = this.btnCapnhatPhongQLP;
            this.btnCapnhatPhongQLP.Size = new System.Drawing.Size(188, 32);
            this.btnCapnhatPhongQLP.TabIndex = 3;
            this.btnCapnhatPhongQLP.Text = "Cập nhật phòng";
            this.btnCapnhatPhongQLP.Click += new System.EventHandler(this.btnCapnhatPhongQLP_Click);
            // 
            // btnXoaPhongQLP
            // 
            this.btnXoaPhongQLP.CheckedState.Parent = this.btnXoaPhongQLP;
            this.btnXoaPhongQLP.CustomImages.Parent = this.btnXoaPhongQLP;
            this.btnXoaPhongQLP.FillColor = System.Drawing.Color.DarkGreen;
            this.btnXoaPhongQLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaPhongQLP.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhongQLP.HoverState.Parent = this.btnXoaPhongQLP;
            this.btnXoaPhongQLP.Location = new System.Drawing.Point(255, 64);
            this.btnXoaPhongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhongQLP.Name = "btnXoaPhongQLP";
            this.btnXoaPhongQLP.ShadowDecoration.Parent = this.btnXoaPhongQLP;
            this.btnXoaPhongQLP.Size = new System.Drawing.Size(188, 32);
            this.btnXoaPhongQLP.TabIndex = 3;
            this.btnXoaPhongQLP.Text = "Sửa phòng";
            // 
            // btnThemPhongQLP
            // 
            this.btnThemPhongQLP.CheckedState.Parent = this.btnThemPhongQLP;
            this.btnThemPhongQLP.CustomImages.Parent = this.btnThemPhongQLP;
            this.btnThemPhongQLP.FillColor = System.Drawing.Color.DarkGreen;
            this.btnThemPhongQLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemPhongQLP.ForeColor = System.Drawing.Color.White;
            this.btnThemPhongQLP.HoverState.Parent = this.btnThemPhongQLP;
            this.btnThemPhongQLP.Location = new System.Drawing.Point(25, 64);
            this.btnThemPhongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhongQLP.Name = "btnThemPhongQLP";
            this.btnThemPhongQLP.ShadowDecoration.Parent = this.btnThemPhongQLP;
            this.btnThemPhongQLP.Size = new System.Drawing.Size(188, 32);
            this.btnThemPhongQLP.TabIndex = 3;
            this.btnThemPhongQLP.Text = "Thêm phòng";
            this.btnThemPhongQLP.Click += new System.EventHandler(this.btnThemPhongQLP_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox3.Controls.Add(this.cbbLoaiPhongQLP);
            this.guna2GroupBox3.Controls.Add(this.cbStatusRoom);
            this.guna2GroupBox3.Controls.Add(this.cbbMaPhongQLP);
            this.guna2GroupBox3.Controls.Add(this.label15);
            this.guna2GroupBox3.Controls.Add(this.name);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.Controls.Add(this.txtSoNguoiToiDa);
            this.guna2GroupBox3.Controls.Add(this.txtTenPhong);
            this.guna2GroupBox3.Controls.Add(this.txtGiaPhongQLP);
            this.guna2GroupBox3.Controls.Add(this.label14);
            this.guna2GroupBox3.Controls.Add(this.label13);
            this.guna2GroupBox3.Controls.Add(this.label2);
            this.guna2GroupBox3.Controls.Add(this.label12);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 114);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(507, 251);
            this.guna2GroupBox3.TabIndex = 9;
            this.guna2GroupBox3.Text = "Thông tin Phòng";
            // 
            // cbbLoaiPhongQLP
            // 
            this.cbbLoaiPhongQLP.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiPhongQLP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiPhongQLP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiPhongQLP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiPhongQLP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiPhongQLP.FocusedState.Parent = this.cbbLoaiPhongQLP;
            this.cbbLoaiPhongQLP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiPhongQLP.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbbLoaiPhongQLP.HoverState.Parent = this.cbbLoaiPhongQLP;
            this.cbbLoaiPhongQLP.ItemHeight = 30;
            this.cbbLoaiPhongQLP.ItemsAppearance.Parent = this.cbbLoaiPhongQLP;
            this.cbbLoaiPhongQLP.Location = new System.Drawing.Point(268, 68);
            this.cbbLoaiPhongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiPhongQLP.Name = "cbbLoaiPhongQLP";
            this.cbbLoaiPhongQLP.ShadowDecoration.Parent = this.cbbLoaiPhongQLP;
            this.cbbLoaiPhongQLP.Size = new System.Drawing.Size(200, 36);
            this.cbbLoaiPhongQLP.TabIndex = 19;
            // 
            // cbStatusRoom
            // 
            this.cbStatusRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbStatusRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatusRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatusRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatusRoom.FocusedState.Parent = this.cbStatusRoom;
            this.cbStatusRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatusRoom.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbStatusRoom.HoverState.Parent = this.cbStatusRoom;
            this.cbStatusRoom.ItemHeight = 30;
            this.cbStatusRoom.ItemsAppearance.Parent = this.cbStatusRoom;
            this.cbStatusRoom.Location = new System.Drawing.Point(25, 190);
            this.cbStatusRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatusRoom.Name = "cbStatusRoom";
            this.cbStatusRoom.ShadowDecoration.Parent = this.cbStatusRoom;
            this.cbStatusRoom.Size = new System.Drawing.Size(200, 36);
            this.cbStatusRoom.TabIndex = 19;
            // 
            // cbbMaPhongQLP
            // 
            this.cbbMaPhongQLP.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaPhongQLP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaPhongQLP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaPhongQLP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaPhongQLP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaPhongQLP.FocusedState.Parent = this.cbbMaPhongQLP;
            this.cbbMaPhongQLP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaPhongQLP.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbbMaPhongQLP.HoverState.Parent = this.cbbMaPhongQLP;
            this.cbbMaPhongQLP.ItemHeight = 30;
            this.cbbMaPhongQLP.ItemsAppearance.Parent = this.cbbMaPhongQLP;
            this.cbbMaPhongQLP.Location = new System.Drawing.Point(25, 69);
            this.cbbMaPhongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaPhongQLP.Name = "cbbMaPhongQLP";
            this.cbbMaPhongQLP.ShadowDecoration.Parent = this.cbbMaPhongQLP;
            this.cbbMaPhongQLP.Size = new System.Drawing.Size(200, 36);
            this.cbbMaPhongQLP.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.ForeColor = System.Drawing.Color.DarkGreen;
            this.label15.Location = new System.Drawing.Point(20, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên phòng";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.White;
            this.name.ForeColor = System.Drawing.Color.DarkGreen;
            this.name.Location = new System.Drawing.Point(267, 173);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(87, 15);
            this.name.TabIndex = 7;
            this.name.Text = "Số người tối đa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(22, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tình trạng phòng";
            // 
            // txtSoNguoiToiDa
            // 
            this.txtSoNguoiToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoNguoiToiDa.DefaultText = "";
            this.txtSoNguoiToiDa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoNguoiToiDa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoNguoiToiDa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNguoiToiDa.DisabledState.Parent = this.txtSoNguoiToiDa;
            this.txtSoNguoiToiDa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoNguoiToiDa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNguoiToiDa.FocusedState.Parent = this.txtSoNguoiToiDa;
            this.txtSoNguoiToiDa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoNguoiToiDa.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSoNguoiToiDa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoNguoiToiDa.HoverState.Parent = this.txtSoNguoiToiDa;
            this.txtSoNguoiToiDa.Location = new System.Drawing.Point(270, 195);
            this.txtSoNguoiToiDa.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            this.txtSoNguoiToiDa.PasswordChar = '\0';
            this.txtSoNguoiToiDa.PlaceholderText = "";
            this.txtSoNguoiToiDa.SelectedText = "";
            this.txtSoNguoiToiDa.ShadowDecoration.Parent = this.txtSoNguoiToiDa;
            this.txtSoNguoiToiDa.Size = new System.Drawing.Size(200, 29);
            this.txtSoNguoiToiDa.TabIndex = 15;
            // 
            // txtGiaPhongQLP
            // 
            this.txtGiaPhongQLP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaPhongQLP.DefaultText = "";
            this.txtGiaPhongQLP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaPhongQLP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaPhongQLP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhongQLP.DisabledState.Parent = this.txtGiaPhongQLP;
            this.txtGiaPhongQLP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaPhongQLP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhongQLP.FocusedState.Parent = this.txtGiaPhongQLP;
            this.txtGiaPhongQLP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaPhongQLP.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtGiaPhongQLP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaPhongQLP.HoverState.Parent = this.txtGiaPhongQLP;
            this.txtGiaPhongQLP.Location = new System.Drawing.Point(270, 136);
            this.txtGiaPhongQLP.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaPhongQLP.Name = "txtGiaPhongQLP";
            this.txtGiaPhongQLP.PasswordChar = '\0';
            this.txtGiaPhongQLP.PlaceholderText = "";
            this.txtGiaPhongQLP.SelectedText = "";
            this.txtGiaPhongQLP.ShadowDecoration.Parent = this.txtGiaPhongQLP;
            this.txtGiaPhongQLP.Size = new System.Drawing.Size(200, 29);
            this.txtGiaPhongQLP.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(267, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Giá phòng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(267, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên phòng";
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
            this.guna2GroupBox1.Controls.Add(this.btnTimkiem);
            this.guna2GroupBox1.Controls.Add(this.txtTimKiemRoom);
            this.guna2GroupBox1.Controls.Add(this.lblMaPhongQLP);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(507, 114);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.CheckedState.Parent = this.btnTimkiem;
            this.btnTimkiem.CustomImages.Parent = this.btnTimkiem;
            this.btnTimkiem.FillColor = System.Drawing.Color.DarkGreen;
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.HoverState.Parent = this.btnTimkiem;
            this.btnTimkiem.Location = new System.Drawing.Point(268, 58);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.ShadowDecoration.Parent = this.btnTimkiem;
            this.btnTimkiem.Size = new System.Drawing.Size(117, 32);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            this.txtTimKiemRoom.Location = new System.Drawing.Point(23, 61);
            this.txtTimKiemRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemRoom.Name = "txtTimKiemRoom";
            this.txtTimKiemRoom.PasswordChar = '\0';
            this.txtTimKiemRoom.PlaceholderText = "";
            this.txtTimKiemRoom.SelectedText = "";
            this.txtTimKiemRoom.ShadowDecoration.Parent = this.txtTimKiemRoom;
            this.txtTimKiemRoom.Size = new System.Drawing.Size(212, 29);
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
            this.lblMaPhongQLP.Size = new System.Drawing.Size(124, 15);
            this.lblMaPhongQLP.TabIndex = 2;
            this.lblMaPhongQLP.Text = "Mã phòng/Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHÒNG";
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
            this.txtTenPhong.Location = new System.Drawing.Point(25, 142);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.PasswordChar = '\0';
            this.txtTenPhong.PlaceholderText = "";
            this.txtTenPhong.SelectedText = "";
            this.txtTenPhong.ShadowDecoration.Parent = this.txtTenPhong;
            this.txtTenPhong.Size = new System.Drawing.Size(200, 29);
            this.txtTenPhong.TabIndex = 17;
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 583);
            this.Controls.Add(this.panel1);
            this.Name = "frmQLPhong";
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhsachPhongQLP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemRoom;
        private System.Windows.Forms.Label lblMaPhongQLP;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiPhongQLP;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaPhongQLP;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaPhongQLP;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatusRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtSoNguoiToiDa;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2Button btnDongQLP;
        private Guna.UI2.WinForms.Guna2Button btnCapnhatPhongQLP;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhongQLP;
        private Guna.UI2.WinForms.Guna2Button btnThemPhongQLP;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDanhsachPhongQLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStatusRoom;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhong;
    }
}