namespace WinForms2
{
    partial class FrmDatphong
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
            this.cbbMaPhDP = new System.Windows.Forms.ComboBox();
            this.lblMaPhDP = new System.Windows.Forms.Label();
            this.msktxtMaKHdp = new System.Windows.Forms.MaskedTextBox();
            this.lblMaKHdp = new System.Windows.Forms.Label();
            this.lblNgaynhanPh = new System.Windows.Forms.Label();
            this.lblNgaytraPh = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbbMaPhDP
            // 
            this.cbbMaPhDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbbMaPhDP.FormattingEnabled = true;
            this.cbbMaPhDP.Location = new System.Drawing.Point(171, 27);
            this.cbbMaPhDP.Name = "cbbMaPhDP";
            this.cbbMaPhDP.Size = new System.Drawing.Size(100, 25);
            this.cbbMaPhDP.TabIndex = 3;
            this.cbbMaPhDP.Text = "Nhập trước";
            // 
            // lblMaPhDP
            // 
            this.lblMaPhDP.AutoSize = true;
            this.lblMaPhDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblMaPhDP.Location = new System.Drawing.Point(45, 32);
            this.lblMaPhDP.Name = "lblMaPhDP";
            this.lblMaPhDP.Size = new System.Drawing.Size(82, 20);
            this.lblMaPhDP.TabIndex = 2;
            this.lblMaPhDP.Text = "Mã phòng";
            // 
            // msktxtMaKHdp
            // 
            this.msktxtMaKHdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtMaKHdp.Location = new System.Drawing.Point(177, 68);
            this.msktxtMaKHdp.Name = "msktxtMaKHdp";
            this.msktxtMaKHdp.Size = new System.Drawing.Size(83, 23);
            this.msktxtMaKHdp.TabIndex = 5;
            this.msktxtMaKHdp.Text = "maskedTextBox (KH.001 -> tự tăng)";
            // 
            // lblMaKHdp
            // 
            this.lblMaKHdp.AutoSize = true;
            this.lblMaKHdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaKHdp.Location = new System.Drawing.Point(46, 67);
            this.lblMaKHdp.Name = "lblMaKHdp";
            this.lblMaKHdp.Size = new System.Drawing.Size(109, 18);
            this.lblMaKHdp.TabIndex = 4;
            this.lblMaKHdp.Text = "Mã khách hàng";
            // 
            // lblNgaynhanPh
            // 
            this.lblNgaynhanPh.AutoSize = true;
            this.lblNgaynhanPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNgaynhanPh.Location = new System.Drawing.Point(46, 122);
            this.lblNgaynhanPh.Name = "lblNgaynhanPh";
            this.lblNgaynhanPh.Size = new System.Drawing.Size(123, 18);
            this.lblNgaynhanPh.TabIndex = 4;
            this.lblNgaynhanPh.Text = "Ngày nhận phòng";
            // 
            // lblNgaytraPh
            // 
            this.lblNgaytraPh.AutoSize = true;
            this.lblNgaytraPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNgaytraPh.Location = new System.Drawing.Point(46, 158);
            this.lblNgaytraPh.Name = "lblNgaytraPh";
            this.lblNgaytraPh.Size = new System.Drawing.Size(108, 18);
            this.lblNgaytraPh.TabIndex = 4;
            this.lblNgaytraPh.Text = "Ngày trả phòng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(177, 156);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // FrmDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.msktxtMaKHdp);
            this.Controls.Add(this.lblNgaytraPh);
            this.Controls.Add(this.lblNgaynhanPh);
            this.Controls.Add(this.lblMaKHdp);
            this.Controls.Add(this.cbbMaPhDP);
            this.Controls.Add(this.lblMaPhDP);
            this.Name = "FrmDatphong";
            this.Text = "Đặt phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaPhDP;
        private System.Windows.Forms.Label lblMaPhDP;
        private System.Windows.Forms.MaskedTextBox msktxtMaKHdp;
        private System.Windows.Forms.Label lblMaKHdp;
        private System.Windows.Forms.Label lblNgaynhanPh;
        private System.Windows.Forms.Label lblNgaytraPh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}