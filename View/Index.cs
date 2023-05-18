using FaceRecognition.View;
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

namespace FaceRecognition
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AuseBtn_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
        }

        private void Recogbtn_Click(object sender, EventArgs e)
        {
            Recognition obj = new Recognition();
            obj.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ViewAttendence adt = new ViewAttendence();
            adt.Show();
        }
    }
}
