namespace WinForms2
{
    partial class Thongke
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
            this.lblMaHDtk = new System.Windows.Forms.Label();
            this.lblTongTN = new System.Windows.Forms.Label();
            this.msktxtMaHDtk = new System.Windows.Forms.MaskedTextBox();
            this.txtTongTN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMaHDtk
            // 
            this.lblMaHDtk.AutoSize = true;
            this.lblMaHDtk.Location = new System.Drawing.Point(69, 23);
            this.lblMaHDtk.Name = "lblMaHDtk";
            this.lblMaHDtk.Size = new System.Drawing.Size(65, 13);
            this.lblMaHDtk.TabIndex = 0;
            this.lblMaHDtk.Text = "Mã hóa đơn";
            // 
            // lblTongTN
            // 
            this.lblTongTN.AutoSize = true;
            this.lblTongTN.Location = new System.Drawing.Point(69, 58);
            this.lblTongTN.Name = "lblTongTN";
            this.lblTongTN.Size = new System.Drawing.Size(77, 13);
            this.lblTongTN.TabIndex = 0;
            this.lblTongTN.Text = "Tổng thu nhập";
            // 
            // msktxtMaHDtk
            // 
            this.msktxtMaHDtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.msktxtMaHDtk.Location = new System.Drawing.Point(155, 17);
            this.msktxtMaHDtk.Name = "msktxtMaHDtk";
            this.msktxtMaHDtk.Size = new System.Drawing.Size(83, 23);
            this.msktxtMaHDtk.TabIndex = 2;
            this.msktxtMaHDtk.Text = "Truy xuất";
            // 
            // txtTongTN
            // 
            this.txtTongTN.Location = new System.Drawing.Point(155, 58);
            this.txtTongTN.Name = "txtTongTN";
            this.txtTongTN.Size = new System.Drawing.Size(241, 20);
            this.txtTongTN.TabIndex = 3;
            this.txtTongTN.Text = "Tổng tiền các mã hóa đơn (Truy xuất) trong ngày";
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTongTN);
            this.Controls.Add(this.msktxtMaHDtk);
            this.Controls.Add(this.lblTongTN);
            this.Controls.Add(this.lblMaHDtk);
            this.Name = "Thongke";
            this.Text = "Thongke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHDtk;
        private System.Windows.Forms.Label lblTongTN;
        private System.Windows.Forms.MaskedTextBox msktxtMaHDtk;
        private System.Windows.Forms.TextBox txtTongTN;
    }
}