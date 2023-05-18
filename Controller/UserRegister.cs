using Emgu.CV;
using Emgu.CV.Structure;
using FaceRecognition.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognition.Controller
{
    public class UserRegister
    {
        private Bitmap cropImage;
        private String FileName;
        private int FileID;
        private Image<Bgr, byte> resizedImage;
        private string Filepath;
        private Bitmap resizeIma; 
        private DataBase conn = new DataBase();
        private static UserRegister instant = new UserRegister();

        public UserRegister() {
            //conn.DataConnection();
        }
        public void setCropImage(Bitmap image)
        {            
            this.cropImage = image;
        }
        public void RenameFile() {
            this.FileName =FileID.ToString();
        }
        public void GetFilenumber() {
          this.FileID = conn.LastFaceid()+1;
        }
        public void StoreFile() {
            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(cropImage);
            resizedImage = myImage.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            resizedImage.Save("faces/" + this.FileID + ".png");
        }
        public void RegisterUserDetails(string name, string address, string batch, string email)
        {
            this.Filepath = "/faces/" + this.FileID + ".png";
            conn.RegisterUser(name, Filepath);
            this.FileID = conn.LastFaceid();
            conn.AddStudentDetails(name, address, batch, email, this.FileID);
        }
        public static UserRegister getInstance() {
            return instant;
        }
        public Bitmap resizeimage() {
            this.resizeIma = this.resizedImage.ToBitmap();
            return this.resizeIma;
        }
        public void CurrentDate() { 
        
        }
       
    }
}
