using FaceRecognition.Controller;
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

namespace FaceRecognition.View
{
    public partial class ViewAttendence : MetroForm
    {
        private FaceController facecon = new FaceController();
        private string batch;
        private List<int> studentID;
        private List<DateTime> registertime;
        private List<string> mailList;

        public ViewAttendence()
        {
            InitializeComponent();
        }
        private void Viewbtn_Click(object sender, EventArgs e)
        {
            batch = BatchCode.Text;
            string date = metroDateTime1.Value.ToShortDateString();

            DataTable.DataSource = facecon.getstudentLIst(date,batch);
            Number.Text = facecon.getNumberOFstu(date,batch).ToString();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            batch = BatchCode.Text;
            mailList = facecon.StudentMails(batch);
            registertime = facecon.Studentretime(batch);
            facecon.startNotify(mailList,registertime);
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            facecon.removedata();
        }       
    }
}
