namespace WinForms2
{
    partial class FrmCTDichvu
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
            this.grbDanhsachDV = new System.Windows.Forms.GroupBox();
            this.dtgDanhsachKH = new System.Windows.Forms.DataGridView();
            this.grbCTDichvu = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.msktxtGia = new System.Windows.Forms.MaskedTextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblMaLoaiDV = new System.Windows.Forms.Label();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.btnXoaLoaiDV = new System.Windows.Forms.Button();
            this.btnThemLoaiDV = new System.Windows.Forms.Button();
            this.btnCapnhatLoaiDV = new System.Windows.Forms.Button();
            this.grbbtnLoaiDV = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhsachDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhsachKH)).BeginInit();
            this.grbCTDichvu.SuspendLayout();
            this.grbbtnLoaiDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhsachDV
            // 
            this.grbDanhsachDV.AutoSize = true;
            this.grbDanhsachDV.Controls.Add(this.dtgDanhsachKH);
            this.grbDanhsachDV.Location = new System.Drawing.Point(390, 12);
            this.grbDanhsachDV.Name = "grbDanhsachDV";
            this.grbDanhsachDV.Size = new System.Drawing.Size(497, 410);
            this.grbDanhsachDV.TabIndex = 11;
            this.grbDanhsachDV.TabStop = false;
            this.grbDanhsachDV.Text = "Danh sách dịch vụ";
            // 
            // dtgDanhsachKH
            // 
            this.dtgDanhsachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhsachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDV,
            this.colMaLoaiDV,
            this.colTenLoaiDV,
            this.colDonvi,
            this.colGia});
            this.dtgDanhsachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhsachKH.Location = new System.Drawing.Point(3, 16);
            this.dtgDanhsachKH.Name = "dtgDanhsachKH";
            this.dtgDanhsachKH.Size = new System.Drawing.Size(491, 391);
            this.dtgDanhsachKH.TabIndex = 0;
            // 
            // grbCTDichvu
            // 
            this.grbCTDichvu.AutoSize = true;
            this.grbCTDichvu.Controls.Add(this.comboBox2);
            this.grbCTDichvu.Controls.Add(this.comboBox1);
            this.grbCTDichvu.Controls.Add(this.cbbMaDV);
            this.grbCTDichvu.Controls.Add(this.txtTenDV);
            this.grbCTDichvu.Controls.Add(this.msktxtGia);
            this.grbCTDichvu.Controls.Add(this.lblGia);
            this.grbCTDichvu.Controls.Add(this.lblSoluong);
            this.grbCTDichvu.Controls.Add(this.lblTenDV);
            this.grbCTDichvu.Controls.Add(this.lblMaLoaiDV);
            this.grbCTDichvu.Controls.Add(this.lblMaDV);
            this.grbCTDichvu.Location = new System.Drawing.Point(10, 12);
            this.grbCTDichvu.Name = "grbCTDichvu";
            this.grbCTDichvu.Size = new System.Drawing.Size(374, 307);
            this.grbCTDichvu.TabIndex = 10;
            this.grbCTDichvu.TabStop = false;
            this.grbCTDichvu.Text = "Chi tiết dịch vụ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Nhập trước (N.001, N.002: Nước, DA: đồ ăn)";
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Location = new System.Drawing.Point(137, 23);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(100, 25);
            this.cbbMaDV.TabIndex = 1;
            this.cbbMaDV.Text = "Truy xuất (01: Nước, 02: đồ ăn)";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTenDV.Location = new System.Drawing.Point(137, 85);
            this.txtTenDV.Multiline = true;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(197, 58);
            this.txtTenDV.TabIndex = 3;
            this.txtTenDV.Text = "textBox (truy xuất từ Mã loại dịch vụ: (N.001: Nước ngọt, N.002: Bia)";
            // 
            // msktxtGia
            // 
            this.msktxtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtGia.Location = new System.Drawing.Point(137, 184);
            this.msktxtGia.Name = "msktxtGia";
            this.msktxtGia.Size = new System.Drawing.Size(100, 23);
            this.msktxtGia.TabIndex = 5;
            this.msktxtGia.Text = "maskedTextBox (200.000)";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblGia.Location = new System.Drawing.Point(6, 183);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(31, 18);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "Giá";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSoluong.Location = new System.Drawing.Point(6, 151);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(50, 18);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Đơn vị";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTenDV.Location = new System.Drawing.Point(6, 87);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(110, 18);
            this.lblTenDV.TabIndex = 0;
            this.lblTenDV.Text = "Tên loại dịch vụ";
            // 
            // lblMaLoaiDV
            // 
            this.lblMaLoaiDV.AutoSize = true;
            this.lblMaLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaLoaiDV.Location = new System.Drawing.Point(6, 56);
            this.lblMaLoaiDV.Name = "lblMaLoaiDV";
            this.lblMaLoaiDV.Size = new System.Drawing.Size(106, 18);
            this.lblMaLoaiDV.TabIndex = 0;
            this.lblMaLoaiDV.Text = "Mã loại dịch vụ";
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaDV.Location = new System.Drawing.Point(6, 25);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(79, 18);
            this.lblMaDV.TabIndex = 0;
            this.lblMaDV.Text = "Mã dịch vụ";
            // 
            // btnXoaLoaiDV
            // 
            this.btnXoaLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnXoaLoaiDV.Location = new System.Drawing.Point(222, 19);
            this.btnXoaLoaiDV.Name = "btnXoaLoaiDV";
            this.btnXoaLoaiDV.Size = new System.Drawing.Size(113, 29);
            this.btnXoaLoaiDV.TabIndex = 8;
            this.btnXoaLoaiDV.Text = "Xóa dịch vụ";
            this.btnXoaLoaiDV.UseVisualStyleBackColor = true;
            // 
            // btnThemLoaiDV
            // 
            this.btnThemLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnThemLoaiDV.Location = new System.Drawing.Point(6, 19);
            this.btnThemLoaiDV.Name = "btnThemLoaiDV";
            this.btnThemLoaiDV.Size = new System.Drawing.Size(128, 29);
            this.btnThemLoaiDV.TabIndex = 7;
            this.btnThemLoaiDV.Text = "Thêm dịch vụ";
            this.btnThemLoaiDV.UseVisualStyleBackColor = true;
            // 
            // btnCapnhatLoaiDV
            // 
            this.btnCapnhatLoaiDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCapnhatLoaiDV.Location = new System.Drawing.Point(110, 54);
            this.btnCapnhatLoaiDV.Name = "btnCapnhatLoaiDV";
            this.btnCapnhatLoaiDV.Size = new System.Drawing.Size(136, 29);
            this.btnCapnhatLoaiDV.TabIndex = 9;
            this.btnCapnhatLoaiDV.Text = "Cập nhật thông tin";
            this.btnCapnhatLoaiDV.UseVisualStyleBackColor = true;
            // 
            // grbbtnLoaiDV
            // 
            this.grbbtnLoaiDV.Controls.Add(this.btnCapnhatLoaiDV);
            this.grbbtnLoaiDV.Controls.Add(this.btnThemLoaiDV);
            this.grbbtnLoaiDV.Controls.Add(this.btnXoaLoaiDV);
            this.grbbtnLoaiDV.Location = new System.Drawing.Point(10, 225);
            this.grbbtnLoaiDV.Name = "grbbtnLoaiDV";
            this.grbbtnLoaiDV.Size = new System.Drawing.Size(374, 94);
            this.grbbtnLoaiDV.TabIndex = 12;
            this.grbbtnLoaiDV.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 25);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Nhập trước (Chai, ly, dĩa,...)";
            // 
            // colMaDV
            // 
            this.colMaDV.HeaderText = "Mã dịch vụ";
            this.colMaDV.Name = "colMaDV";
            // 
            // colMaLoaiDV
            // 
            this.colMaLoaiDV.HeaderText = "Mã loại dịch vụ";
            this.colMaLoaiDV.Name = "colMaLoaiDV";
            // 
            // colTenLoaiDV
            // 
            this.colTenLoaiDV.HeaderText = "Tên loại dịch vụ";
            this.colTenLoaiDV.Name = "colTenLoaiDV";
            // 
            // colDonvi
            // 
            this.colDonvi.HeaderText = "Đơn vị";
            this.colDonvi.Name = "colDonvi";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            // 
            // FrmCTDichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 453);
            this.Controls.Add(this.grbbtnLoaiDV);
            this.Controls.Add(this.grbDanhsachDV);
            this.Controls.Add(this.grbCTDichvu);
            this.Name = "FrmCTDichvu";
            this.Text = "Chi tiết dịch vụ";
            this.grbDanhsachDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhsachKH)).EndInit();
            this.grbCTDichvu.ResumeLayout(false);
            this.grbCTDichvu.PerformLayout();
            this.grbbtnLoaiDV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhsachDV;
        private System.Windows.Forms.DataGridView dtgDanhsachKH;
        private System.Windows.Forms.GroupBox grbCTDichvu;
        private System.Windows.Forms.MaskedTextBox msktxtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMaLoaiDV;
        private System.Windows.Forms.Button btnXoaLoaiDV;
        private System.Windows.Forms.Button btnThemLoaiDV;
        private System.Windows.Forms.Button btnCapnhatLoaiDV;
        private System.Windows.Forms.GroupBox grbbtnLoaiDV;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
    }
}