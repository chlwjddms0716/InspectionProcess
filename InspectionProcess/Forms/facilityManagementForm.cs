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


        private void uscSearch_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {
            dteStartDate.EditValue = null;
            dteFinishDate.EditValue = null;
        }

        private void uscSearch_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
            bdsInspection.DataSource = DataRepository.Inspection.GetAllbyDate(dteStartDate.DateTime.Date, dteFinishDate.DateTime.Date);
        }
    }
}
