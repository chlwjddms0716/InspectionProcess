using DevExpress.XtraEditors;
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
    public partial class DisposalManagementForm : XtraForm
    {
        public DisposalManagementForm()
        {
            InitializeComponent();
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bdsMerchandise.DataSource = await DataRepository.Merchandise.GetAllAsync();
            bdsWarehouse.DataSource = await DataRepository.Warehouse.GetbyDumpAsync();
          
        }


        private void btnDisposal_Click(object sender, EventArgs e)
        {
            DeleteOneKeeping();
        }


        internal void DeleteOneKeeping()
        {
            Keeping keeping = bdsKeeping.Current as Keeping;
            if (keeping == null)
                return;
            if (Helpers.DeleteHelper.SureToDelete() == false)
                return;

            DataRepository.Keeping.Delete(keeping);

            bdsKeeping.Remove(keeping);
        }

        private void uscSearch_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {
            
            lkuWarehouseName.EditValue = null;

            dteKeepFrom.EditValue = null;
            dteKeepTo.EditValue = null;
        }

        private void uscSearch_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
            bdsKeeping.DataSource = DataRepository.Keeping.Searchby((int?)lkuWarehouseName.EditValue, (DateTime?)dteKeepFrom.EditValue, (DateTime?)dteKeepTo.EditValue);
        }

      
    }
}
