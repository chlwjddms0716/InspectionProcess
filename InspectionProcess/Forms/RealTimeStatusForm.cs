using DevExpress.XtraReports.Serialization;
using DevExpress.XtraEditors;
using InspectionProcess.Data;
using InspectionProcess.Forms.UpdateForms;
using InspectionProcess.Properties;
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
using ProgressBar = DevExpress.XtraEditors.ProgressBar;

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

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int warehouseA = DataRepository.Warehouse.GetbyCountA();
            int warehouseB = DataRepository.Warehouse.GetbyCountB();
            int warehouseC = DataRepository.Warehouse.GetbyCountC();
            int DumpA = DataRepository.Warehouse.GetbyCountDumpA();
            int DumpB = DataRepository.Warehouse.GetbyCountDumpB();

            if (0 <= warehouseA && warehouseA < 35)
                pcbwarehouseA.Image = Resources.warehouse0;
            if (36 < warehouseA && warehouseA < 75)
                pcbwarehouseA.Image = Resources.warehouse1;
            if (76 < warehouseA && warehouseA < 101)
                pcbwarehouseA.Image = Resources.warehouse3;
            lblwarehouseA.Text = Convert.ToString(warehouseA);

            if (0 <= warehouseB && warehouseB < 35)
                pcbwarehouseB.Image = Resources.warehouse0;
            if (36 < warehouseB && warehouseB < 75)
                pcbwarehouseB.Image = Resources.warehouse1;
            if (76 < warehouseB && warehouseB < 101)
                pcbwarehouseB.Image = Resources.warehouse3;
            lblwarehouseB.Text = Convert.ToString(warehouseB);

            if (0 <= warehouseC && warehouseC < 35)
                pcbwarehouseC.Image = Resources.warehouse0;
            if (36 < warehouseC && warehouseC < 75)
                pcbwarehouseC.Image = Resources.warehouse1;
            if (76 < warehouseC && warehouseC < 101)
                pcbwarehouseC.Image = Resources.warehouse3;
            lblwarehouseC.Text = Convert.ToString(warehouseC);

            if (0 <= DumpA && DumpA < 35)
                pcbdumpA.Image = Resources.warehouse0;
            if (36 < DumpA && DumpA < 75)
                pcbdumpA.Image = Resources.warehouse1;
            if (76 < DumpA && DumpA < 101)
                pcbdumpA.Image = Resources.warehouse3;
            lbldumpA.Text = Convert.ToString(DumpA);

            if (0 <= DumpB && DumpB < 35)
                pcbdumpB.Image = Resources.warehouse0;
            if (36 < DumpB && DumpB < 75)
                pcbdumpB.Image = Resources.warehouse1;
            if (76 < DumpB && DumpB < 101)
                pcbdumpB.Image = Resources.warehouse3;
            lbldumpB.Text = Convert.ToString(DumpB);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }



        protected override void OnShown(EventArgs e)
        {
            p
        }
           
    }
}
