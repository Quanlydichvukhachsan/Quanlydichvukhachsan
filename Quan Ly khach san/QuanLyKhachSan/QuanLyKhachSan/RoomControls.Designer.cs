namespace QuanLyKhachSan
{
    partial class RoomControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomControls));
            this.lbRoom = new System.Windows.Forms.Label();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(79)))));
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.ForeColor = System.Drawing.Color.White;
            this.lbRoom.Location = new System.Drawing.Point(6, 39);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(59, 13);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.Text = "Phong 102";
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoom.Image")));
            this.pictureBoxRoom.Location = new System.Drawing.Point(6, 1);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(56, 35);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoom.TabIndex = 1;
            this.pictureBoxRoom.TabStop = false;
            this.pictureBoxRoom.Click += new System.EventHandler(this.pictureBoxRoom_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(79)))));
            this.panelContainer.Controls.Add(this.lbRoom);
            this.panelContainer.Controls.Add(this.pictureBoxRoom);
            this.panelContainer.Location = new System.Drawing.Point(0, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(65, 60);
            this.panelContainer.TabIndex = 2;
            // 
            // RoomControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
            this.Name = "RoomControls";
            this.Size = new System.Drawing.Size(73, 71);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.Panel panelContainer;
    }
}
