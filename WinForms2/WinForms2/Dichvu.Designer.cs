namespace WinForms2
{
    partial class Dichvu
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
            this.grbDichvu = new System.Windows.Forms.GroupBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lblTenDVhd = new System.Windows.Forms.Label();
            this.lblMaDVhd = new System.Windows.Forms.Label();
            this.grbbtnDV = new System.Windows.Forms.GroupBox();
            this.btnCapnhatDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.msktxtMaKH = new System.Windows.Forms.MaskedTextBox();
            this.grbDichvu.SuspendLayout();
            this.grbbtnDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDichvu
            // 
            this.grbDichvu.AutoSize = true;
            this.grbDichvu.Controls.Add(this.msktxtMaKH);
            this.grbDichvu.Controls.Add(this.grbbtnDV);
            this.grbDichvu.Controls.Add(this.txtTenDV);
            this.grbDichvu.Controls.Add(this.lblTenDVhd);
            this.grbDichvu.Controls.Add(this.lblMaDVhd);
            this.grbDichvu.Location = new System.Drawing.Point(12, 12);
            this.grbDichvu.Name = "grbDichvu";
            this.grbDichvu.Size = new System.Drawing.Size(370, 227);
            this.grbDichvu.TabIndex = 10;
            this.grbDichvu.TabStop = false;
            this.grbDichvu.Text = "Dịch vụ";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtTenDV.Location = new System.Drawing.Point(140, 50);
            this.txtTenDV.Multiline = true;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(197, 58);
            this.txtTenDV.TabIndex = 10;
            this.txtTenDV.Text = "textBox (Giặt ủi, ăn uống, massage)";
            // 
            // lblTenDVhd
            // 
            this.lblTenDVhd.AutoSize = true;
            this.lblTenDVhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTenDVhd.Location = new System.Drawing.Point(9, 68);
            this.lblTenDVhd.Name = "lblTenDVhd";
            this.lblTenDVhd.Size = new System.Drawing.Size(83, 18);
            this.lblTenDVhd.TabIndex = 0;
            this.lblTenDVhd.Text = "Tên dịch vụ";
            // 
            // lblMaDVhd
            // 
            this.lblMaDVhd.AutoSize = true;
            this.lblMaDVhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMaDVhd.Location = new System.Drawing.Point(9, 25);
            this.lblMaDVhd.Name = "lblMaDVhd";
            this.lblMaDVhd.Size = new System.Drawing.Size(79, 18);
            this.lblMaDVhd.TabIndex = 0;
            this.lblMaDVhd.Text = "Mã dịch vụ";
            // 
            // grbbtnDV
            // 
            this.grbbtnDV.Controls.Add(this.btnCapnhatDV);
            this.grbbtnDV.Controls.Add(this.btnThemDV);
            this.grbbtnDV.Controls.Add(this.btnXoaDV);
            this.grbbtnDV.Location = new System.Drawing.Point(6, 114);
            this.grbbtnDV.Name = "grbbtnDV";
            this.grbbtnDV.Size = new System.Drawing.Size(358, 94);
            this.grbbtnDV.TabIndex = 13;
            this.grbbtnDV.TabStop = false;
            // 
            // btnCapnhatDV
            // 
            this.btnCapnhatDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCapnhatDV.Location = new System.Drawing.Point(110, 54);
            this.btnCapnhatDV.Name = "btnCapnhatDV";
            this.btnCapnhatDV.Size = new System.Drawing.Size(136, 29);
            this.btnCapnhatDV.TabIndex = 9;
            this.btnCapnhatDV.Text = "Cập nhật thông tin";
            this.btnCapnhatDV.UseVisualStyleBackColor = true;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnThemDV.Location = new System.Drawing.Point(6, 19);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(128, 29);
            this.btnThemDV.TabIndex = 7;
            this.btnThemDV.Text = "Thêm dịch vụ";
            this.btnThemDV.UseVisualStyleBackColor = true;
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnXoaDV.Location = new System.Drawing.Point(222, 19);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(113, 29);
            this.btnXoaDV.TabIndex = 8;
            this.btnXoaDV.Text = "Xóa dịch vụ";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            // 
            // msktxtMaKH
            // 
            this.msktxtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtMaKH.Location = new System.Drawing.Point(140, 19);
            this.msktxtMaKH.Name = "msktxtMaKH";
            this.msktxtMaKH.Size = new System.Drawing.Size(83, 23);
            this.msktxtMaKH.TabIndex = 14;
            this.msktxtMaKH.Text = "maskedTextBox (KH.001 -> tự tăng)";
            // 
            // Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDichvu);
            this.Name = "Dichvu";
            this.Text = "Dichvu";
            this.grbDichvu.ResumeLayout(false);
            this.grbDichvu.PerformLayout();
            this.grbbtnDV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDichvu;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label lblTenDVhd;
        private System.Windows.Forms.Label lblMaDVhd;
        private System.Windows.Forms.GroupBox grbbtnDV;
        private System.Windows.Forms.Button btnCapnhatDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.MaskedTextBox msktxtMaKH;
    }
}