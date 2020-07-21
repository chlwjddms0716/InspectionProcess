using InspectionProcess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess.Forms
{
    public partial class facilityManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public facilityManagementForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsInspection.DataSource = DataRepository.Inspection.GetAllbyDate();
        }
    }
}
