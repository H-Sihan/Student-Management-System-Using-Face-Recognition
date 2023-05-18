using Emgu.CV;
using Emgu.CV.Structure;
using FaceRecognition.Controller;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition.View
{
    public partial class Recognition : MetroForm
    {
        private Capture capture;
        private bool captureSate;
        private ImageResizeAdaptee adpater = new ImageResizeApter();
        private Image<Bgr, byte> currentFrame;
        private FaceController facCon=new FaceController();
        private List<int> imageids = new List<int>();
        private int id;
        public Recognition()
        {
            System.Windows.Forms.Application.DoEvents();

            InitializeComponent();
            try
            {
                facCon.LoadFaceDetatils();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                StartRecognition();
            }
        }
        private void StartRecognition()
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
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
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (captureSate)
            {
            currentFrame = capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            facCon.StartFacerecognition(currentFrame);
            capimagebox.Image = facCon.getCurrentRecognitionImage();
            facCon.SetNameAsempty();
            
            if (BactCode.Text != "")
            {
                id = facCon.UserID();
                if (id != 0)
                {
                    if (facCon.CheckPresent(id))
                    {
                        if (facCon.getBatchCode(id) == BactCode.Text)
                        {
                            Registermess.Text = "Registered :)  See you soon ";
                            disImage.Image = Image.FromFile(Application.StartupPath + "/faces/" + id + ".png");
                            facCon.AddToMArksSheet(id, facCon.getBatchCode(id),facCon.getCurrentTime(),facCon.getCurrentDate());
                            Registermess.Text = "Next Pelase....";
                        }
                        else
                        {
                            Registermess.Text = "Sorry This is not your batch";
                        }
                    }
                    else
                    {
                        Registermess.Text = "Your Mark is completed";
                        disImage.Hide();
                    }
                }}}
        }
        private void stopCamera(object sender, FormClosingEventArgs e)
        {
            if (captureSate)
            {
                StartRecognition();
                capture.Dispose();
                this.Close();
            }
        }
  
    }
}
