namespace WinForms2
{
    partial class FrmHoadon
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
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblMaKHhd = new System.Windows.Forms.Label();
            this.lblTenKHhd = new System.Windows.Forms.Label();
            this.lblMaLoaiDVhd = new System.Windows.Forms.Label();
            this.lblTenLoaiDVhd = new System.Windows.Forms.Label();
            this.lblTongsoluong = new System.Windows.Forms.Label();
            this.msktxtMaHD = new System.Windows.Forms.MaskedTextBox();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.msktxtSoluong = new System.Windows.Forms.MaskedTextBox();
            this.txtMaKHhd = new System.Windows.Forms.TextBox();
            this.txtTenKHhd = new System.Windows.Forms.TextBox();
            this.grbCTHoadon = new System.Windows.Forms.GroupBox();
            this.txtMaPhHD = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaPhHD = new System.Windows.Forms.Label();
            this.grbDanhsachHD = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKHhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKHhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaloaiDVhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiDVhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCTHoadon.SuspendLayout();
            this.grbDanhsachHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaHD.Location = new System.Drawing.Point(6, 28);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(87, 18);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // lblMaKHhd
            // 
            this.lblMaKHhd.AutoSize = true;
            this.lblMaKHhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaKHhd.Location = new System.Drawing.Point(7, 57);
            this.lblMaKHhd.Name = "lblMaKHhd";
            this.lblMaKHhd.Size = new System.Drawing.Size(109, 18);
            this.lblMaKHhd.TabIndex = 0;
            this.lblMaKHhd.Text = "Mã khách hàng";
            // 
            // lblTenKHhd
            // 
            this.lblTenKHhd.AutoSize = true;
            this.lblTenKHhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTenKHhd.Location = new System.Drawing.Point(245, 57);
            this.lblTenKHhd.Name = "lblTenKHhd";
            this.lblTenKHhd.Size = new System.Drawing.Size(113, 18);
            this.lblTenKHhd.TabIndex = 0;
            this.lblTenKHhd.Text = "Tên khách hàng";
            // 
            // lblMaLoaiDVhd
            // 
            this.lblMaLoaiDVhd.AutoSize = true;
            this.lblMaLoaiDVhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaLoaiDVhd.Location = new System.Drawing.Point(7, 90);
            this.lblMaLoaiDVhd.Name = "lblMaLoaiDVhd";
            this.lblMaLoaiDVhd.Size = new System.Drawing.Size(106, 18);
            this.lblMaLoaiDVhd.TabIndex = 0;
            this.lblMaLoaiDVhd.Text = "Mã loại dịch vụ";
            // 
            // lblTenLoaiDVhd
            // 
            this.lblTenLoaiDVhd.AutoSize = true;
            this.lblTenLoaiDVhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTenLoaiDVhd.Location = new System.Drawing.Point(245, 84);
            this.lblTenLoaiDVhd.Name = "lblTenLoaiDVhd";
            this.lblTenLoaiDVhd.Size = new System.Drawing.Size(110, 18);
            this.lblTenLoaiDVhd.TabIndex = 0;
            this.lblTenLoaiDVhd.Text = "Tên loại dịch vụ";
            // 
            // lblTongsoluong
            // 
            this.lblTongsoluong.AutoSize = true;
            this.lblTongsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTongsoluong.Location = new System.Drawing.Point(7, 148);
            this.lblTongsoluong.Name = "lblTongsoluong";
            this.lblTongsoluong.Size = new System.Drawing.Size(103, 18);
            this.lblTongsoluong.TabIndex = 0;
            this.lblTongsoluong.Text = "Tổng số lượng";
            // 
            // msktxtMaHD
            // 
            this.msktxtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtMaHD.Location = new System.Drawing.Point(138, 26);
            this.msktxtMaHD.Name = "msktxtMaHD";
            this.msktxtMaHD.Size = new System.Drawing.Size(83, 23);
            this.msktxtMaHD.TabIndex = 1;
            this.msktxtMaHD.Text = "maskedTextBox (HD.001 -> tự tăng)";
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Location = new System.Drawing.Point(138, 84);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(83, 25);
            this.cbbMaDV.TabIndex = 9;
            this.cbbMaDV.Text = "Truy xuất -> Nhập mã (";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTenDV.Location = new System.Drawing.Point(376, 84);
            this.txtTenDV.Multiline = true;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(197, 58);
            this.txtTenDV.TabIndex = 10;
            this.txtTenDV.Text = "textBox (Nước ngọt cocacola, bia heneiken,...)";
            // 
            // msktxtSoluong
            // 
            this.msktxtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtSoluong.Location = new System.Drawing.Point(138, 148);
            this.msktxtSoluong.Name = "msktxtSoluong";
            this.msktxtSoluong.Size = new System.Drawing.Size(39, 23);
            this.msktxtSoluong.TabIndex = 11;
            this.msktxtSoluong.Text = "maskedTextBox (Nhập số: 01,02,12,20,99)";
            // 
            // txtMaKHhd
            // 
            this.txtMaKHhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtMaKHhd.Location = new System.Drawing.Point(138, 55);
            this.txtMaKHhd.Name = "txtMaKHhd";
            this.txtMaKHhd.Size = new System.Drawing.Size(83, 23);
            this.txtMaKHhd.TabIndex = 12;
            this.txtMaKHhd.Text = "textBox (Truy xuất)";
            // 
            // txtTenKHhd
            // 
            this.txtTenKHhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTenKHhd.Location = new System.Drawing.Point(376, 55);
            this.txtTenKHhd.Name = "txtTenKHhd";
            this.txtTenKHhd.Size = new System.Drawing.Size(181, 23);
            this.txtTenKHhd.TabIndex = 12;
            this.txtTenKHhd.Text = "textBox (Truy xuất)";
            // 
            // grbCTHoadon
            // 
            this.grbCTHoadon.AutoSize = true;
            this.grbCTHoadon.Controls.Add(this.txtTenKHhd);
            this.grbCTHoadon.Controls.Add(this.txtMaPhHD);
            this.grbCTHoadon.Controls.Add(this.txtMaKHhd);
            this.grbCTHoadon.Controls.Add(this.maskedTextBox1);
            this.grbCTHoadon.Controls.Add(this.msktxtSoluong);
            this.grbCTHoadon.Controls.Add(this.txtTenDV);
            this.grbCTHoadon.Controls.Add(this.cbbMaDV);
            this.grbCTHoadon.Controls.Add(this.lblTongTien);
            this.grbCTHoadon.Controls.Add(this.msktxtMaHD);
            this.grbCTHoadon.Controls.Add(this.lblTongsoluong);
            this.grbCTHoadon.Controls.Add(this.lblTenLoaiDVhd);
            this.grbCTHoadon.Controls.Add(this.lblMaLoaiDVhd);
            this.grbCTHoadon.Controls.Add(this.lblMaPhHD);
            this.grbCTHoadon.Controls.Add(this.lblTenKHhd);
            this.grbCTHoadon.Controls.Add(this.lblMaKHhd);
            this.grbCTHoadon.Controls.Add(this.lblMaHD);
            this.grbCTHoadon.Location = new System.Drawing.Point(12, 12);
            this.grbCTHoadon.Name = "grbCTHoadon";
            this.grbCTHoadon.Size = new System.Drawing.Size(582, 190);
            this.grbCTHoadon.TabIndex = 9;
            this.grbCTHoadon.TabStop = false;
            // 
            // txtMaPhHD
            // 
            this.txtMaPhHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtMaPhHD.Location = new System.Drawing.Point(325, 26);
            this.txtMaPhHD.Name = "txtMaPhHD";
            this.txtMaPhHD.Size = new System.Drawing.Size(83, 23);
            this.txtMaPhHD.TabIndex = 12;
            this.txtMaPhHD.Text = "textBox (Truy xuất)";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.maskedTextBox1.Location = new System.Drawing.Point(278, 148);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(141, 23);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.Text = "maskedTextBox (Nhập số: 01,02,12,20,99)";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTongTien.Location = new System.Drawing.Point(203, 150);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(69, 18);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // lblMaPhHD
            // 
            this.lblMaPhHD.AutoSize = true;
            this.lblMaPhHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaPhHD.Location = new System.Drawing.Point(245, 28);
            this.lblMaPhHD.Name = "lblMaPhHD";
            this.lblMaPhHD.Size = new System.Drawing.Size(74, 18);
            this.lblMaPhHD.TabIndex = 0;
            this.lblMaPhHD.Text = "Mã phòng";
            // 
            // grbDanhsachHD
            // 
            this.grbDanhsachHD.AutoSize = true;
            this.grbDanhsachHD.Controls.Add(this.dataGridView1);
            this.grbDanhsachHD.Location = new System.Drawing.Point(12, 208);
            this.grbDanhsachHD.Name = "grbDanhsachHD";
            this.grbDanhsachHD.Size = new System.Drawing.Size(851, 190);
            this.grbDanhsachHD.TabIndex = 9;
            this.grbDanhsachHD.TabStop = false;
            this.grbDanhsachHD.Text = "Chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaKHhd,
            this.colMaPhHD,
            this.colTenKHhd,
            this.colMaloaiDVhd,
            this.colTenLoaiDVhd,
            this.colTongSoluong,
            this.colTongTien});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.Name = "colMaHD";
            // 
            // colMaKHhd
            // 
            this.colMaKHhd.HeaderText = "Mã khách hàng";
            this.colMaKHhd.Name = "colMaKHhd";
            // 
            // colMaPhHD
            // 
            this.colMaPhHD.HeaderText = "Mã phòng";
            this.colMaPhHD.Name = "colMaPhHD";
            // 
            // colTenKHhd
            // 
            this.colTenKHhd.HeaderText = "Tên khách hàng";
            this.colTenKHhd.Name = "colTenKHhd";
            // 
            // colMaloaiDVhd
            // 
            this.colMaloaiDVhd.HeaderText = "Mã loại dịch vụ";
            this.colMaloaiDVhd.Name = "colMaloaiDVhd";
            // 
            // colTenLoaiDVhd
            // 
            this.colTenLoaiDVhd.HeaderText = "Tên loại dịch vụ";
            this.colTenLoaiDVhd.Name = "colTenLoaiDVhd";
            // 
            // colTongSoluong
            // 
            this.colTongSoluong.HeaderText = "Tổng số lượng";
            this.colTongSoluong.Name = "colTongSoluong";
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            // 
            // FrmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 495);
            this.Controls.Add(this.grbDanhsachHD);
            this.Controls.Add(this.grbCTHoadon);
            this.Name = "FrmHoadon";
            this.Text = "Hoadon";
            this.grbCTHoadon.ResumeLayout(false);
            this.grbCTHoadon.PerformLayout();
            this.grbDanhsachHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblMaKHhd;
        private System.Windows.Forms.Label lblTenKHhd;
        private System.Windows.Forms.Label lblMaLoaiDVhd;
        private System.Windows.Forms.Label lblTenLoaiDVhd;
        private System.Windows.Forms.Label lblTongsoluong;
        private System.Windows.Forms.MaskedTextBox msktxtMaHD;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.MaskedTextBox msktxtSoluong;
        private System.Windows.Forms.TextBox txtMaKHhd;
        private System.Windows.Forms.TextBox txtTenKHhd;
        private System.Windows.Forms.GroupBox grbCTHoadon;
        private System.Windows.Forms.TextBox txtMaPhHD;
        private System.Windows.Forms.Label lblMaPhHD;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox grbDanhsachHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKHhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKHhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaloaiDVhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiDVhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
    }
}