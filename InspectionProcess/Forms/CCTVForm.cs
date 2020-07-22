using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }
    }
}
