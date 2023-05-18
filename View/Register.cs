using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using FaceRecognition.Controller;

namespace FaceRecognition.View
{
    public partial class Register : MetroForm
    {
        
        private Capture capture;        
        private bool captureSate;
        private FaceController Fcobj = new FaceController();
        private Image<Bgr, Byte> ImageFrame;
        private Bitmap cropImage;
        private static string Pattern="^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public Register()
        {
            InitializeComponent();
            StratCam();
        }
        private void StratCam()
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show("Vision Camera not detected");
                }
            }
            if (capture != null)
            {
                if (captureSate)
                { 
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    Application.Idle += ProcessFrame;
                }
                captureSate = !captureSate;
            } 
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (captureSate)
            {
                ImageFrame = capture.QueryFrame();
                Fcobj.FaceProcess(ImageFrame);
                cam1.Image = ImageFrame;
            }
        }
        private void cam1_Click(object sender, EventArgs e)
        {
            
            cropImage = Fcobj.CropImage();
            pictureBox1.Image = cropImage;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (StuTex.Text != "" && AddTex.Text != "" && BatchTex.Text != "" && ConTEx.Text != "" && System.Text.RegularExpressions.Regex.IsMatch(ConTEx.Text, Pattern)!=false && ConTEx.Text !="")
                {
                    Fcobj.Userregister(StuTex.Text, AddTex.Text, BatchTex.Text, ConTEx.Text);
                    MessageBox.Show("Sucessfully registered");
                }
                else
                {
                    MessageBox.Show("Fill all blanks and make sure email corrent validations ----");
                }
           }
            catch (Exception ex) {
                MessageBox.Show("There something not going well Plses check again");
            }
        }
        private void closewindow(object sender, FormClosingEventArgs e)
        {
            if (captureSate)
            {
                StratCam();
                capture.Dispose();
                this.Close();
            }
        }
        
    }
}
