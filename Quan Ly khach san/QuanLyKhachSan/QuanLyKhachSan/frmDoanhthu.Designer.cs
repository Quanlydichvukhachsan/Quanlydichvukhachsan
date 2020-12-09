
namespace QuanLyKhachSan
{
    partial class frmDoanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.chDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgvDoanhthuDT = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnKetqua = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayDT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMaPhongQLP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhthuDT)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.chDoanhThu);
            this.panel1.Controls.Add(this.dtgvDoanhthuDT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 613);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.CheckedState.Parent = this.btnDong;
            this.btnDong.CustomImages.Parent = this.btnDong;
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.HoverState.Parent = this.btnDong;
            this.btnDong.Location = new System.Drawing.Point(699, 565);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShadowDecoration.Parent = this.btnDong;
            this.btnDong.Size = new System.Drawing.Size(180, 36);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            // 
            // chDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chDoanhThu.Legends.Add(legend1);
            this.chDoanhThu.Location = new System.Drawing.Point(15, 180);
            this.chDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chDoanhThu.Name = "chDoanhThu";
            this.chDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Phòng Đơn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Phòng Đôi";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Phòng Vip";
            this.chDoanhThu.Series.Add(series1);
            this.chDoanhThu.Series.Add(series2);
            this.chDoanhThu.Series.Add(series3);
            this.chDoanhThu.Size = new System.Drawing.Size(463, 363);
            this.chDoanhThu.TabIndex = 6;
            this.chDoanhThu.Text = "Tỷ Lệ Doanh Thu theo Phòng";
            title1.Name = "Tỷ Lệ Doanh Thu Theo Phòng";
            this.chDoanhThu.Titles.Add(title1);
            // 
            // dtgvDoanhthuDT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhthuDT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDoanhthuDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoanhthuDT.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDoanhthuDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDoanhthuDT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDoanhthuDT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDoanhthuDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDoanhthuDT.ColumnHeadersHeight = 102;
            this.dtgvDoanhthuDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDoanhthuDT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDoanhthuDT.EnableHeadersVisualStyles = false;
            this.dtgvDoanhthuDT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDoanhthuDT.Location = new System.Drawing.Point(484, 178);
            this.dtgvDoanhthuDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDoanhthuDT.Name = "dtgvDoanhthuDT";
            this.dtgvDoanhthuDT.RowHeadersVisible = false;
            this.dtgvDoanhthuDT.RowHeadersWidth = 51;
            this.dtgvDoanhthuDT.RowTemplate.Height = 24;
            this.dtgvDoanhthuDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDoanhthuDT.Size = new System.Drawing.Size(532, 364);
            this.dtgvDoanhthuDT.TabIndex = 5;
            this.dtgvDoanhthuDT.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvDoanhthuDT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhthuDT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDoanhthuDT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDoanhthuDT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDoanhthuDT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDoanhthuDT.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhthuDT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDoanhthuDT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.dtgvDoanhthuDT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDoanhthuDT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvDoanhthuDT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDoanhthuDT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvDoanhthuDT.ThemeStyle.HeaderStyle.Height = 102;
            this.dtgvDoanhthuDT.ThemeStyle.ReadOnly = false;
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkGreen;
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDoanhthuDT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.FillWeight = 81.21828F;
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tỷ Lệ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doanh Thu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(8, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 116);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2GroupBox1);
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 102);
            this.panel3.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Controls.Add(this.btnKetqua);
            this.guna2GroupBox1.Controls.Add(this.dtpNgayDT);
            this.guna2GroupBox1.Controls.Add(this.lblMaPhongQLP);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(999, 102);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Chức năng";
            // 
            // btnKetqua
            // 
            this.btnKetqua.CheckedState.Parent = this.btnKetqua;
            this.btnKetqua.CustomImages.Parent = this.btnKetqua;
            this.btnKetqua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.btnKetqua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKetqua.ForeColor = System.Drawing.Color.White;
            this.btnKetqua.HoverState.Parent = this.btnKetqua;
            this.btnKetqua.Location = new System.Drawing.Point(685, 48);
            this.btnKetqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.ShadowDecoration.Parent = this.btnKetqua;
            this.btnKetqua.Size = new System.Drawing.Size(180, 36);
            this.btnKetqua.TabIndex = 4;
            this.btnKetqua.Text = "Xem Kết Quả";
            // 
            // dtpNgayDT
            // 
            this.dtpNgayDT.CheckedState.Parent = this.dtpNgayDT;
            this.dtpNgayDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.dtpNgayDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDT.ForeColor = System.Drawing.Color.White;
            this.dtpNgayDT.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayDT.HoverState.Parent = this.dtpNgayDT;
            this.dtpNgayDT.Location = new System.Drawing.Point(111, 48);
            this.dtpNgayDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDT.Name = "dtpNgayDT";
            this.dtpNgayDT.ShadowDecoration.Parent = this.dtpNgayDT;
            this.dtpNgayDT.Size = new System.Drawing.Size(464, 36);
            this.dtpNgayDT.TabIndex = 3;
            this.dtpNgayDT.Value = new System.DateTime(2020, 11, 26, 14, 11, 57, 186);
            // 
            // lblMaPhongQLP
            // 
            this.lblMaPhongQLP.AutoSize = true;
            this.lblMaPhongQLP.BackColor = System.Drawing.Color.White;
            this.lblMaPhongQLP.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaPhongQLP.Location = new System.Drawing.Point(28, 58);
            this.lblMaPhongQLP.Name = "lblMaPhongQLP";
            this.lblMaPhongQLP.Size = new System.Drawing.Size(72, 20);
            this.lblMaPhongQLP.TabIndex = 2;
            this.lblMaPhongQLP.Text = "Thời Gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOANH THU";
            // 
            // frmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 613);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoanhthu";
            this.Text = "frmDoanhthu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhthuDT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblMaPhongQLP;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayDT;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDoanhThu;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvDoanhthuDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button btnKetqua;
    }
}