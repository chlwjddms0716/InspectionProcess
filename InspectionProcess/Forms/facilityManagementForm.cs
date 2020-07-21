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
    public partial class FacilityManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public FacilityManagementForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsInspection.DataSource = DataRepository.Inspection.GetAllbyDate(dteStartDate.DateTime, dteFinishDate.DateTime);
        }
    }
}
