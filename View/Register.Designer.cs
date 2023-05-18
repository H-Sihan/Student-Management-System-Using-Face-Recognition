namespace FaceRecognition.View
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.cam1 = new Emgu.CV.UI.ImageBox();
            this.btnregister = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.StuTex = new MetroFramework.Controls.MetroTextBox();
            this.AddTex = new MetroFramework.Controls.MetroTextBox();
            this.ConTEx = new MetroFramework.Controls.MetroTextBox();
            this.BatchTex = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cam1
            // 
            this.cam1.Location = new System.Drawing.Point(55, 63);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(354, 240);
            this.cam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cam1.TabIndex = 2;
            this.cam1.TabStop = false;
            this.cam1.Click += new System.EventHandler(this.cam1_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(282, 428);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(140, 47);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Register Student";
            this.btnregister.UseSelectable = true;
            this.btnregister.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(421, 311);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Student Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(421, 371);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Student Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 309);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Student Batch";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 374);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(160, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Student Notification Email";
            // 
            // StuTex
            // 
            // 
            // 
            // 
            this.StuTex.CustomButton.Image = null;
            this.StuTex.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.StuTex.CustomButton.Name = "";
            this.StuTex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.StuTex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StuTex.CustomButton.TabIndex = 1;
            this.StuTex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StuTex.CustomButton.UseSelectable = true;
            this.StuTex.CustomButton.Visible = false;
            this.StuTex.Lines = new string[0];
            this.StuTex.Location = new System.Drawing.Point(425, 334);
            this.StuTex.MaxLength = 32767;
            this.StuTex.Name = "StuTex";
            this.StuTex.PasswordChar = '\0';
            this.StuTex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StuTex.SelectedText = "";
            this.StuTex.SelectionLength = 0;
            this.StuTex.SelectionStart = 0;
            this.StuTex.Size = new System.Drawing.Size(354, 23);
            this.StuTex.TabIndex = 15;
            this.StuTex.UseSelectable = true;
            this.StuTex.WaterMark = "Student Name";
            this.StuTex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StuTex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddTex
            // 
            // 
            // 
            // 
            this.AddTex.CustomButton.Image = null;
            this.AddTex.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.AddTex.CustomButton.Name = "";
            this.AddTex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AddTex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddTex.CustomButton.TabIndex = 1;
            this.AddTex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddTex.CustomButton.UseSelectable = true;
            this.AddTex.CustomButton.Visible = false;
            this.AddTex.Lines = new string[0];
            this.AddTex.Location = new System.Drawing.Point(426, 397);
            this.AddTex.MaxLength = 32767;
            this.AddTex.Name = "AddTex";
            this.AddTex.PasswordChar = '\0';
            this.AddTex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddTex.SelectedText = "";
            this.AddTex.SelectionLength = 0;
            this.AddTex.SelectionStart = 0;
            this.AddTex.Size = new System.Drawing.Size(354, 23);
            this.AddTex.TabIndex = 16;
            this.AddTex.UseSelectable = true;
            this.AddTex.WaterMark = "Home Address";
            this.AddTex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddTex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConTEx
            // 
            // 
            // 
            // 
            this.ConTEx.CustomButton.Image = null;
            this.ConTEx.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.ConTEx.CustomButton.Name = "";
            this.ConTEx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ConTEx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConTEx.CustomButton.TabIndex = 1;
            this.ConTEx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConTEx.CustomButton.UseSelectable = true;
            this.ConTEx.CustomButton.Visible = false;
            this.ConTEx.Lines = new string[0];
            this.ConTEx.Location = new System.Drawing.Point(55, 399);
            this.ConTEx.MaxLength = 32767;
            this.ConTEx.Name = "ConTEx";
            this.ConTEx.PasswordChar = '\0';
            this.ConTEx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConTEx.SelectedText = "";
            this.ConTEx.SelectionLength = 0;
            this.ConTEx.SelectionStart = 0;
            this.ConTEx.Size = new System.Drawing.Size(354, 23);
            this.ConTEx.TabIndex = 18;
            this.ConTEx.UseSelectable = true;
            this.ConTEx.WaterMark = "Email";
            this.ConTEx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConTEx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BatchTex
            // 
            this.BatchTex.FormattingEnabled = true;
            this.BatchTex.ItemHeight = 23;
            this.BatchTex.Items.AddRange(new object[] {
            "AAAAA",
            "BBBBB",
            "CCCCC",
            "DDDDD"});
            this.BatchTex.Location = new System.Drawing.Point(55, 334);
            this.BatchTex.Name = "BatchTex";
            this.BatchTex.PromptText = "Batch Code";
            this.BatchTex.Size = new System.Drawing.Size(354, 29);
            this.BatchTex.TabIndex = 19;
            this.BatchTex.UseSelectable = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.BatchTex);
            this.Controls.Add(this.ConTEx);
            this.Controls.Add(this.AddTex);
            this.Controls.Add(this.StuTex);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.cam1);
            this.Name = "Register";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "User Register Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closewindow);
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cam1;
        private MetroFramework.Controls.MetroButton btnregister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox StuTex;
        private MetroFramework.Controls.MetroTextBox AddTex;
        private MetroFramework.Controls.MetroTextBox ConTEx;
        private MetroFramework.Controls.MetroComboBox BatchTex;
    }
}