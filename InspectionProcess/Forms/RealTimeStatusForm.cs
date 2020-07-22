using InspectionProcess.Forms.UpdateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess.Forms
{
    public partial class RealTimeStatusForm : DevExpress.XtraEditors.XtraForm
    {
        delegate void CrossThreadSafetySetText(Control lblhum, String text);

        private void CSafeSetText(Control lblTemp, String text)
        {
            if (lblhum.InvokeRequired)
                lblhum.Invoke(new CrossThreadSafetySetText(CSafeSetText), lblhum, text);
            else
                lblhum.Text = text;
        }
        public RealTimeStatusForm()
        {
            InitializeComponent();
        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            CCTVForm form = new CCTVForm();
            form.Show();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                byte[] recv = new byte[6];
                serialPort1.Read(recv, 0, 6);

                float t = ((recv[0] * 256) + recv[1]) / 100;
                float h = ((recv[2] * 256) + recv[3]) / 100;

                if (t <= 40 && h <= 60 && h > 10)
                {
                    lblTemp.Text = t.ToString();
                    CSafeSetText(lblTemp, h.ToString());
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }
    }
}