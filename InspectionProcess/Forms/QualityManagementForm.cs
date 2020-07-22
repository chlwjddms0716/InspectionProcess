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
            inspectionResultBindingSource.DataSource = DataRepository.InspectionResult.SearchByQuality((int?)lkuInspectionID.EditValue, (int?)lkuProductId.EditValue, (int?)lkuInspectionTeamName.EditValue);
        }

        

        private void QualityManagementForm_Load(object sender, EventArgs e)
        {
            teamBindingSource.DataSource = DataRepository.Team.GetAll();
            inspectionBindingSource.DataSource = DataRepository.Inspection.GetAll();
            productBindingSource.DataSource = DataRepository.Product.GetAll();

            //TODO : 양품개수가 10개 일 때, 검사 횟수가 3번이면 창고.count에 들어가게 해야 함
        }

        private void btnReInspection_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lkuInspectionID.EditValue = null;
            lkuProductId.EditValue = null;
            lkuInspectionTeamName.EditValue = null;
            //하이
        }
    }
}
