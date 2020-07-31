using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MjpegProcessor;

namespace InspectionProcess.Forms.UpdateForms
{
    public partial class CCTVForm : DevExpress.XtraEditors.XtraForm
    {
        public CCTVForm()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void CCTVForm_Load(object sender, EventArgs e)
        {
            try
            {
                MjpegDecoder mjpeg = new MjpegDecoder();
                mjpeg.FrameReady += mjpeg_FrameReady;
                mjpeg.ParseStream(new Uri("http://192.168.6.91:5000"));
            }
            catch
            {
                MessageBox.Show("CCTV 서버가 실행되지 않았습니다.");
            }
        }
        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            pictureBox1.Image = e.Bitmap;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
