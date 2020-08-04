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

            //if(DataRepository.InspectionResult.GetbyNormal() == 10)
            //{
            //    DataRepository.InspectionResult.DeleteByNormal();

            //    Warehouse warehouse = new Warehouse();
            //    warehouse.Name = 
            //    DataRepository.Warehouse.Insert(warehouse);
            //}
            //DataRepository.InspectionResult.DeleteByDefective();
            //TODO : 양품개수가 10개 일 때, 검사 횟수가 3번이면 창고.count, 지정된 창고에 들어가게 해야 함

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            //하이
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

        
    }
}
