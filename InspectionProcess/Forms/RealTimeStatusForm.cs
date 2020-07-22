using InspectionProcess.Forms.UpdateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess.Forms
{
    public partial class RealTimeStatusForm : DevExpress.XtraEditors.XtraForm
    {
        public RealTimeStatusForm()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            CCTVForm form = new CCTVForm();
            form.Show();
        }
    }
}
