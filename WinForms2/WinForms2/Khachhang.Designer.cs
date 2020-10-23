namespace WinForms2
{
    partial class FrmKH
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
            this.grbTTKhachhang = new System.Windows.Forms.GroupBox();
            this.cbbGioitinhKH = new System.Windows.Forms.ComboBox();
            this.txtDiachiKH = new System.Windows.Forms.TextBox();
            this.txtPhongHH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.msktxtSodienthoaiKH = new System.Windows.Forms.MaskedTextBox();
            this.msktxtSoCMND = new System.Windows.Forms.MaskedTextBox();
            this.msktxtMaKH = new System.Windows.Forms.MaskedTextBox();
            this.lblPhongHH = new System.Windows.Forms.Label();
            this.lblSodienthoaiKH = new System.Windows.Forms.Label();
            this.lblGioitinhKH = new System.Windows.Forms.Label();
            this.lblDiachiKH = new System.Windows.Forms.Label();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.grbDanhsachKH = new System.Windows.Forms.GroupBox();
            this.dtgDanhsachKH = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbbtnPh = new System.Windows.Forms.GroupBox();
            this.btnCapnhatKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.grbTTKhachhang.SuspendLayout();
            this.grbDanhsachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhsachKH)).BeginInit();
            this.grbbtnPh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTKhachhang
            // 
            this.grbTTKhachhang.AutoSize = true;
            this.grbTTKhachhang.Controls.Add(this.cbbGioitinhKH);
            this.grbTTKhachhang.Controls.Add(this.txtDiachiKH);
            this.grbTTKhachhang.Controls.Add(this.txtPhongHH);
            this.grbTTKhachhang.Controls.Add(this.txtTenKH);
            this.grbTTKhachhang.Controls.Add(this.msktxtSodienthoaiKH);
            this.grbTTKhachhang.Controls.Add(this.msktxtSoCMND);
            this.grbTTKhachhang.Controls.Add(this.msktxtMaKH);
            this.grbTTKhachhang.Controls.Add(this.lblPhongHH);
            this.grbTTKhachhang.Controls.Add(this.lblSodienthoaiKH);
            this.grbTTKhachhang.Controls.Add(this.lblGioitinhKH);
            this.grbTTKhachhang.Controls.Add(this.lblDiachiKH);
            this.grbTTKhachhang.Controls.Add(this.lblSoCMND);
            this.grbTTKhachhang.Controls.Add(this.lblTenKH);
            this.grbTTKhachhang.Controls.Add(this.lblMaKH);
            this.grbTTKhachhang.Location = new System.Drawing.Point(12, 12);
            this.grbTTKhachhang.Name = "grbTTKhachhang";
            this.grbTTKhachhang.Size = new System.Drawing.Size(374, 289);
            this.grbTTKhachhang.TabIndex = 8;
            this.grbTTKhachhang.TabStop = false;
            this.grbTTKhachhang.Text = "Thông tin khách hàng";
            // 
            // cbbGioitinhKH
            // 
            this.cbbGioitinhKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbbGioitinhKH.FormattingEnabled = true;
            this.cbbGioitinhKH.Location = new System.Drawing.Point(138, 184);
            this.cbbGioitinhKH.Name = "cbbGioitinhKH";
            this.cbbGioitinhKH.Size = new System.Drawing.Size(100, 25);
            this.cbbGioitinhKH.TabIndex = 5;
            this.cbbGioitinhKH.Text = "Nhập trước (Nam, nữ, không muốn trả lời)";
            // 
            // txtDiachiKH
            // 
            this.txtDiachiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDiachiKH.Location = new System.Drawing.Point(138, 120);
            this.txtDiachiKH.Multiline = true;
            this.txtDiachiKH.Name = "txtDiachiKH";
            this.txtDiachiKH.Size = new System.Drawing.Size(217, 53);
            this.txtDiachiKH.TabIndex = 4;
            this.txtDiachiKH.Text = "textBox";
            // 
            // txtPhongHH
            // 
            this.txtPhongHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPhongHH.Location = new System.Drawing.Point(138, 247);
            this.txtPhongHH.Name = "txtPhongHH";
            this.txtPhongHH.Size = new System.Drawing.Size(108, 23);
            this.txtPhongHH.TabIndex = 0;
            this.txtPhongHH.Text = "textBox (Truy xuất)";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTenKH.Location = new System.Drawing.Point(138, 58);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(184, 23);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.Text = "textBox (Trần Nguyên Nam Dương)";
            // 
            // msktxtSodienthoaiKH
            // 
            this.msktxtSodienthoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtSodienthoaiKH.Location = new System.Drawing.Point(138, 216);
            this.msktxtSodienthoaiKH.Name = "msktxtSodienthoaiKH";
            this.msktxtSodienthoaiKH.Size = new System.Drawing.Size(135, 23);
            this.msktxtSodienthoaiKH.TabIndex = 6;
            this.msktxtSodienthoaiKH.Text = "maskedTextBox";
            // 
            // msktxtSoCMND
            // 
            this.msktxtSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtSoCMND.Location = new System.Drawing.Point(138, 89);
            this.msktxtSoCMND.Name = "msktxtSoCMND";
            this.msktxtSoCMND.Size = new System.Drawing.Size(108, 23);
            this.msktxtSoCMND.TabIndex = 3;
            this.msktxtSoCMND.Text = "maskedTextBox (284532189)";
            // 
            // msktxtMaKH
            // 
            this.msktxtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtMaKH.Location = new System.Drawing.Point(138, 26);
            this.msktxtMaKH.Name = "msktxtMaKH";
            this.msktxtMaKH.Size = new System.Drawing.Size(83, 23);
            this.msktxtMaKH.TabIndex = 1;
            this.msktxtMaKH.Text = "maskedTextBox (KH.001 -> tự tăng)";
            // 
            // lblPhongHH
            // 
            this.lblPhongHH.AutoSize = true;
            this.lblPhongHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPhongHH.Location = new System.Drawing.Point(7, 246);
            this.lblPhongHH.Name = "lblPhongHH";
            this.lblPhongHH.Size = new System.Drawing.Size(118, 18);
            this.lblPhongHH.TabIndex = 0;
            this.lblPhongHH.Text = "Phòng hiện hành";
            // 
            // lblSodienthoaiKH
            // 
            this.lblSodienthoaiKH.AutoSize = true;
            this.lblSodienthoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSodienthoaiKH.Location = new System.Drawing.Point(7, 215);
            this.lblSodienthoaiKH.Name = "lblSodienthoaiKH";
            this.lblSodienthoaiKH.Size = new System.Drawing.Size(94, 18);
            this.lblSodienthoaiKH.TabIndex = 0;
            this.lblSodienthoaiKH.Text = "Số điện thoại";
            // 
            // lblGioitinhKH
            // 
            this.lblGioitinhKH.AutoSize = true;
            this.lblGioitinhKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblGioitinhKH.Location = new System.Drawing.Point(7, 183);
            this.lblGioitinhKH.Name = "lblGioitinhKH";
            this.lblGioitinhKH.Size = new System.Drawing.Size(62, 18);
            this.lblGioitinhKH.TabIndex = 0;
            this.lblGioitinhKH.Text = "Giới tính";
            // 
            // lblDiachiKH
            // 
            this.lblDiachiKH.AutoSize = true;
            this.lblDiachiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDiachiKH.Location = new System.Drawing.Point(7, 119);
            this.lblDiachiKH.Name = "lblDiachiKH";
            this.lblDiachiKH.Size = new System.Drawing.Size(53, 18);
            this.lblDiachiKH.TabIndex = 0;
            this.lblDiachiKH.Text = "Địa chỉ";
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSoCMND.Location = new System.Drawing.Point(7, 88);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(77, 18);
            this.lblSoCMND.TabIndex = 0;
            this.lblSoCMND.Text = "Số CMND";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTenKH.Location = new System.Drawing.Point(7, 57);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(113, 18);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaKH.Location = new System.Drawing.Point(7, 25);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(109, 18);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // grbDanhsachKH
            // 
            this.grbDanhsachKH.AutoSize = true;
            this.grbDanhsachKH.Controls.Add(this.dtgDanhsachKH);
            this.grbDanhsachKH.Location = new System.Drawing.Point(392, 12);
            this.grbDanhsachKH.Name = "grbDanhsachKH";
            this.grbDanhsachKH.Size = new System.Drawing.Size(497, 389);
            this.grbDanhsachKH.TabIndex = 9;
            this.grbDanhsachKH.TabStop = false;
            this.grbDanhsachKH.Text = "Danh sách khách hàng";
            // 
            // dtgDanhsachKH
            // 
            this.dtgDanhsachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhsachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSoCMND,
            this.colDiachi,
            this.colGioitinh,
            this.colSodienthoai,
            this.colPhongHH});
            this.dtgDanhsachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhsachKH.Location = new System.Drawing.Point(3, 16);
            this.dtgDanhsachKH.Name = "dtgDanhsachKH";
            this.dtgDanhsachKH.Size = new System.Drawing.Size(491, 370);
            this.dtgDanhsachKH.TabIndex = 0;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.Name = "colTenKH";
            // 
            // colSoCMND
            // 
            this.colSoCMND.HeaderText = "Số CMND";
            this.colSoCMND.Name = "colSoCMND";
            // 
            // colDiachi
            // 
            this.colDiachi.HeaderText = "Địa chỉ";
            this.colDiachi.Name = "colDiachi";
            // 
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colSodienthoai
            // 
            this.colSodienthoai.HeaderText = "Số điện thoại";
            this.colSodienthoai.Name = "colSodienthoai";
            // 
            // colPhongHH
            // 
            this.colPhongHH.HeaderText = "Phòng";
            this.colPhongHH.Name = "colPhongHH";
            // 
            // grbbtnPh
            // 
            this.grbbtnPh.Controls.Add(this.btnCapnhatKH);
            this.grbbtnPh.Controls.Add(this.btnThemKH);
            this.grbbtnPh.Controls.Add(this.btnXoaKH);
            this.grbbtnPh.Location = new System.Drawing.Point(12, 307);
            this.grbbtnPh.Name = "grbbtnPh";
            this.grbbtnPh.Size = new System.Drawing.Size(374, 94);
            this.grbbtnPh.TabIndex = 10;
            this.grbbtnPh.TabStop = false;
            // 
            // btnCapnhatKH
            // 
            this.btnCapnhatKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCapnhatKH.Location = new System.Drawing.Point(110, 54);
            this.btnCapnhatKH.Name = "btnCapnhatKH";
            this.btnCapnhatKH.Size = new System.Drawing.Size(136, 29);
            this.btnCapnhatKH.TabIndex = 9;
            this.btnCapnhatKH.Text = "Cập nhật thông tin";
            this.btnCapnhatKH.UseVisualStyleBackColor = true;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnThemKH.Location = new System.Drawing.Point(6, 19);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(128, 29);
            this.btnThemKH.TabIndex = 7;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnXoaKH.Location = new System.Drawing.Point(222, 19);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(113, 29);
            this.btnXoaKH.TabIndex = 8;
            this.btnXoaKH.Text = "Xóa khách hàng";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            // 
            // FrmKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.grbbtnPh);
            this.Controls.Add(this.grbDanhsachKH);
            this.Controls.Add(this.grbTTKhachhang);
            this.Name = "FrmKH";
            this.Text = "Khách hàng";
            this.grbTTKhachhang.ResumeLayout(false);
            this.grbTTKhachhang.PerformLayout();
            this.grbDanhsachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhsachKH)).EndInit();
            this.grbbtnPh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTTKhachhang;
        private System.Windows.Forms.ComboBox cbbGioitinhKH;
        private System.Windows.Forms.TextBox txtDiachiKH;
        private System.Windows.Forms.TextBox txtPhongHH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.MaskedTextBox msktxtSodienthoaiKH;
        private System.Windows.Forms.MaskedTextBox msktxtSoCMND;
        private System.Windows.Forms.MaskedTextBox msktxtMaKH;
        private System.Windows.Forms.Label lblPhongHH;
        private System.Windows.Forms.Label lblSodienthoaiKH;
        private System.Windows.Forms.Label lblGioitinhKH;
        private System.Windows.Forms.Label lblDiachiKH;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.GroupBox grbDanhsachKH;
        private System.Windows.Forms.DataGridView dtgDanhsachKH;
        private System.Windows.Forms.GroupBox grbbtnPh;
        private System.Windows.Forms.Button btnCapnhatKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongHH;
    }
}