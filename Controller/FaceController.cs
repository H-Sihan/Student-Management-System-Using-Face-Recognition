using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FaceRecognition.Model;
using System.Data;

namespace FaceRecognition.Controller
{
    public class FaceController
    {

        private static FaceDetection facede;
        private static UserRegister UseRe;
        private static UserRecognition Usrecogni;
        private static DataBase database;
        private static ParentNotify notify;
        private static DateHelper date;
        private static TimeHelper timeCurrent;
        private List<int> StidentID = new List<int>();
        private Bitmap resizedimage;
        private Bitmap userImage;

        public FaceController()
        {
            FaceDetect();
            facede.LoadHarrCascade();
            Usrecogni.setImageIDs(database.LoadImageIDs());
        }
        public static void FaceDetect() {
           
           facede = FaceDetection.getInstance();
           UseRe = UserRegister.getInstance();
           database = DataBase.getInstances();
           Usrecogni = UserRecognition.getinstances();
           notify = ParentNotify.getinstances();
           date = DateHelper.getinstance();
           timeCurrent = TimeHelper.getInstances();
        }
        public void FaceProcess(Image<Bgr, Byte> ImageFrame)
        {
            facede.SetCurrentFrame(ImageFrame);
            facede.ImageGray();
            facede.ImageToBitmap();
            facede.HarrCasCade();
        }
        public void Userregister(string name,string address,string batch,string email ){
            UseRe.setCropImage(userImage);
            UseRe.GetFilenumber();
            UseRe.RenameFile();
            UseRe.RegisterUserDetails(name, address, batch, email);
            UseRe.StoreFile();
        }
        public void LoadFaceDetatils() {
            Usrecogni.loadHrrcascade();
            Usrecogni.loadfaces();
        }
        public void StartFacerecognition(Image<Bgr, byte> currentFrame)
        {
            Usrecogni.addname();
            Usrecogni.setImage(currentFrame);
            Usrecogni.convert2Gray();
            Usrecogni.FaceDetector();
            Usrecogni.setT();
            Usrecogni.nameContainer();
        }
        public int UserID() {
            return Usrecogni.GetUSerID();
        }
        public Image<Bgr, byte> getCurrentRecognitionImage()
        {
            return Usrecogni.getCuurentframe();
        }
        public void SetNameAsempty(){
            Usrecogni.setnameempty();
        }
        public void Resize_Image() {
            this.resizedimage=UseRe.resizeimage();  
        }
        public Bitmap CropImage(){
           this.userImage= facede.GetCropImage();
           return userImage;
        }
        public bool CheckPresent(int ID) {
           return database.checkPresetage(ID);
        }
     
        public void AddToMArksSheet(int StudentID,string batch,DateTime time,DateTime date) {
            database.MakeAttendecs(StudentID,batch,time,date);
        }
        public DateTime getCurrentDate() {
           return date.Convert2Date();
        }
        public string getBatchCode(int StudentID) {
          return database.getbatchCode(StudentID);
        }
        public DateTime getCurrentTime() {
            return timeCurrent.getCurrentTime();
        }
        public DataTable getstudentLIst(string date, string batch)
        {
           return database.getstudentLIst(date,batch);
        }
        public int getNumberOFstu(string date, string batch)
        {
            return database.totalStudents(date,batch);
        }
        public List<string>StudentMails(string batchcode)
        {
            return database.getstudentmail(batchcode);
        }
        public List<DateTime> Studentretime(string batchcode)
        {
            return database.getcurrentlist(batchcode);
        }

        public void startNotify(List<string> mailList, List<DateTime> registertime)
        {
           notify.setmail(mailList,registertime);
        }

        public void removedata()
        {
            database.deletaeAttendece();
        }
    }
}
