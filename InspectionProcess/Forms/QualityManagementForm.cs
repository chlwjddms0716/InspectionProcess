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

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            teamBindingSource.DataSource = await DataRepository.Team.GetAllAsync();
            inspectionBindingSource.DataSource = await DataRepository.Inspection.GetAllAsync();
            productBindingSource.DataSource = await DataRepository.Product.GetAllAsync();

        }

        private void searchButtonControl1_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {
            lkuInspectionID.EditValue = null;
            lkuProductId.EditValue = null;
            lkuInspectionTeamName.EditValue = null;
        }

        private void searchButtonControl1_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
            inspectionResultBindingSource.DataSource = DataRepository.InspectionResult.SearchByQuality((int?)lkuInspectionID.EditValue, (int?)lkuProductId.EditValue, (int?)lkuInspectionTeamName.EditValue);
        }

        private void btnReInspection_Click(object sender, EventArgs e)
        {
            InspectionResult inspectionResult = inspectionResultBindingSource.Current as InspectionResult;
            if (inspectionResult == null)
                return;
            InsertInspectionForm form = new InsertInspectionForm(inspectionResult);
            form.ShowDialog();
        }
    }
}
