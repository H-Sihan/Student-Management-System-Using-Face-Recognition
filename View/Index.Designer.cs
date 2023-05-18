namespace FaceRecognition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AuseBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Recogbtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AuseBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Recogbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // AuseBtn
            // 
            this.AuseBtn.ActiveControl = null;
            this.AuseBtn.BackColor = System.Drawing.Color.Yellow;
            this.AuseBtn.Controls.Add(this.pictureBox1);
            this.AuseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AuseBtn.Location = new System.Drawing.Point(572, 30);
            this.AuseBtn.Name = "AuseBtn";
            this.AuseBtn.Size = new System.Drawing.Size(185, 218);
            this.AuseBtn.TabIndex = 0;
            this.AuseBtn.Text = "Register User";
            this.AuseBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AuseBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.AuseBtn.UseCustomBackColor = true;
            this.AuseBtn.UseCustomForeColor = true;
            this.AuseBtn.UseSelectable = true;
            this.AuseBtn.Click += new System.EventHandler(this.AuseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Recogbtn
            // 
            this.Recogbtn.ActiveControl = null;
            this.Recogbtn.BackColor = System.Drawing.Color.Yellow;
            this.Recogbtn.Controls.Add(this.pictureBox2);
            this.Recogbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recogbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Recogbtn.Location = new System.Drawing.Point(43, 84);
            this.Recogbtn.Name = "Recogbtn";
            this.Recogbtn.Size = new System.Drawing.Size(397, 378);
            this.Recogbtn.TabIndex = 1;
            this.Recogbtn.Text = "Recognition User";
            this.Recogbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Recogbtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Recogbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Recogbtn.UseCustomBackColor = true;
            this.Recogbtn.UseCustomForeColor = true;
            this.Recogbtn.UseSelectable = true;
            this.Recogbtn.UseStyleColors = true;
            this.Recogbtn.UseTileImage = true;
            this.Recogbtn.Click += new System.EventHandler(this.Recogbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Yellow;
            this.metroTile1.Controls.Add(this.pictureBox3);
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Location = new System.Drawing.Point(572, 254);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(185, 208);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Check User";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 157);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(792, 485);
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.Recogbtn);
            this.Controls.Add(this.AuseBtn);
            this.MaximumSize = new System.Drawing.Size(792, 485);
            this.MinimumSize = new System.Drawing.Size(792, 485);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Automated Face Attendance System";
            this.AuseBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Recogbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AuseBtn;
        private MetroFramework.Controls.MetroTile Recogbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

