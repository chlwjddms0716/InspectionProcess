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
    public partial class QualityManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public QualityManagementForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
 
           
                bdsInspectionResult.DataSource = DataRepository.InspectionResult.SearchByQuality(Convert.ToInt32(txeInspectionid.Text), Convert.ToInt32(txeProductId.Text), (int?)lkuInspectionTeamName.EditValue);
           

        }

        

        private void QualityManagementForm_Load(object sender, EventArgs e)
        {
            teamBindingSource.DataSource = DataRepository.Team.GetAll();
        }
    }
}
