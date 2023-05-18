namespace FaceRecognition.View
{
    partial class Recognition
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
            this.disImage = new System.Windows.Forms.PictureBox();
            this.capimagebox = new Emgu.CV.UI.ImageBox();
            this.Registermess = new System.Windows.Forms.Label();
            this.BactCode = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.disImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capimagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // disImage
            // 
            this.disImage.Location = new System.Drawing.Point(367, 21);
            this.disImage.Name = "disImage";
            this.disImage.Size = new System.Drawing.Size(362, 342);
            this.disImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.disImage.TabIndex = 3;
            this.disImage.TabStop = false;
            // 
            // capimagebox
            // 
            this.capimagebox.Location = new System.Drawing.Point(23, 123);
            this.capimagebox.Name = "capimagebox";
            this.capimagebox.Size = new System.Drawing.Size(320, 240);
            this.capimagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capimagebox.TabIndex = 2;
            this.capimagebox.TabStop = false;
            // 
            // Registermess
            // 
            this.Registermess.AutoSize = true;
            this.Registermess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registermess.ForeColor = System.Drawing.Color.LightCoral;
            this.Registermess.Location = new System.Drawing.Point(82, 395);
            this.Registermess.Name = "Registermess";
            this.Registermess.Size = new System.Drawing.Size(76, 31);
            this.Registermess.TabIndex = 4;
            this.Registermess.Text = "Scan";
            // 
            // BactCode
            // 
            this.BactCode.FormattingEnabled = true;
            this.BactCode.ItemHeight = 23;
            this.BactCode.Items.AddRange(new object[] {
            "AAAAA",
            "BBBBB",
            "CCCCC",
            "DDDDD"});
            this.BactCode.Location = new System.Drawing.Point(23, 72);
            this.BactCode.Name = "BactCode";
            this.BactCode.PromptText = "Class";
            this.BactCode.Size = new System.Drawing.Size(320, 29);
            this.BactCode.TabIndex = 5;
            this.BactCode.UseSelectable = true;
            // 
            // Recognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.BactCode);
            this.Controls.Add(this.Registermess);
            this.Controls.Add(this.capimagebox);
            this.Controls.Add(this.disImage);
            this.Name = "Recognition";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Recognition Student Face";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.stopCamera);
            ((System.ComponentModel.ISupportInitialize)(this.disImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capimagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox disImage;
        private Emgu.CV.UI.ImageBox capimagebox;
        private System.Windows.Forms.Label Registermess;
        private MetroFramework.Controls.MetroComboBox BactCode;
    }
}