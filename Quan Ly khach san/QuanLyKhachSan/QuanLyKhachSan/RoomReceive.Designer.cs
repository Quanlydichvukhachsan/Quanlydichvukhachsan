namespace QuanLyKhachSan
{
    partial class RoomReceive
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomReceive));
            this.Room = new Guna.UI.WinForms.GunaImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Room
            // 
            this.Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(131)))), ((int)(((byte)(238)))));
            this.Room.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Room.Image = ((System.Drawing.Image)(resources.GetObject("Room.Image")));
            this.Room.ImageSize = new System.Drawing.Size(64, 64);
            this.Room.Location = new System.Drawing.Point(0, 0);
            this.Room.Name = "Room";
            this.Room.OnHoverImage = null;
            this.Room.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Room.Size = new System.Drawing.Size(110, 119);
            this.Room.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(131)))), ((int)(((byte)(238)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng 102";
            // 
            // RoomReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Room);
            this.Name = "RoomReceive";
            this.Size = new System.Drawing.Size(110, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaImageButton Room;
        private System.Windows.Forms.Label label1;
    }
}
