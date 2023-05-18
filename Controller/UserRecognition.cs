using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace FaceRecognition.Controller
{
    public class UserRecognition
    {
        private Image<Bgr, Byte> currentFrame;
        private HaarCascade face;
        private EigenObjectRecognizer recognizer;
        private MCvTermCriteria termCrit;
        private MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        private Image<Gray, byte> result = null;
        private Image<Gray, byte> gray = null;
        private List<Image<Gray, byte>> trainingfaces = new List<Image<Gray, byte>>();
        private List<string> labels = new List<string>();
        private List<string> IDofPersons = new List<string>();
        private int ContTrain, NumLabels, t;
        private string ID = null;
        private string IDs = null;
        private MCvAvgComp[][] facedReco;
        private static UserRecognition instants = new UserRecognition();
        private List<int> imageids = new List<int>();
        private double scaleFactor = 1.2;
        private int minNabours = 10;
        private int timeeclips;
        
        public UserRecognition() { 
        
        }
        public void setImageIDs(List<int> imageids)
        {
            this.imageids = imageids;
        }
        public void loadHrrcascade()
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");
        }
        public void loadfaces()
        {
            try
            {
                NumLabels = imageids.Count();
                ContTrain = NumLabels;
                string LoadFaces;
                for (int a = 0; a < NumLabels; a++)
                {
                    LoadFaces = imageids[a] + ".png";
                    trainingfaces.Add(new Image<Gray, byte>(Application.StartupPath + "/faces/" + LoadFaces));
                    labels.Add(imageids[a].ToString());
                }
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
        }
        public int getContTrain()
        {
            return ContTrain;
        }
        public List<string> getlabels()
        {
            return labels;
        }
        public void addname()
        {
            IDofPersons.Add("");
        }
        public void setImage(Image<Bgr, Byte> cuFrame)
        {
            currentFrame = cuFrame;
        }
        public void convert2Gray()
        {
            gray = currentFrame.Convert<Gray, Byte>();
        }
        public void FaceDetector()
        {
            facedReco = this.gray.DetectHaarCascade(
            this.face,
            this.scaleFactor,
            this.minNabours,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20));
            foreach (MCvAvgComp f in facedReco[0])
            {
           try
                {
                    if (f.rect.Height >=150 && f.rect.Width >= 150)
                    { 
                    t++;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    currentFrame.Draw(f.rect, new Bgr(Color.Green),2);
                    if (this.trainingfaces.ToArray().Length != 0)
                    {
                        termCrit = new MCvTermCriteria(getContTrain(), 0.001);
                        recognizer = new EigenObjectRecognizer(this.trainingfaces.ToArray(), getlabels().ToArray(), 3500, ref termCrit);
                        ID = recognizer.Recognize(result);
                        currentFrame.Draw(ID, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    }
                    IDofPersons[t - 1] = ID;
                    IDofPersons.Add("");
                    }
                }
                catch (Exception ex) {
                    String a = ex.ToString();
                }
            }
        }
        public void setT()
        {
            t = 0;
        }
        public void nameContainer()
        {
            for (int x = 0; x < this.facedReco[0].Length; x++)
            {
                IDs = IDs + IDofPersons[x] + ", ";
            }
        }
        public Image<Bgr, Byte> getCuurentframe()
        {
            return currentFrame;
        }
        public void Clearname()
        {
            IDofPersons.Clear();
        }
        public void setnameempty()
        {
            IDs = "";
        }
        public static UserRecognition getinstances() {
            return instants;
        }
        public int GetUSerID() {
        if (ID!=null && ID!="") {
            if (timeeclips > 5)
            {
                timeeclips = 0;
                return Int32.Parse(ID);
            }
            timeeclips++;
            }
            return 0;
        }
      
    }
}
