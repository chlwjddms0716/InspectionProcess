using DevExpress.Utils.Extensions;
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
    public partial class WarehouseManagementForm : XtraForm
    {
        public WarehouseManagementForm()
        {
            InitializeComponent();
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //bdsMerchandise.DataSource = await DataRepository.Merchandise.GetAllAsync();
            bdsWarehouse.DataSource = await DataRepository.Warehouse.GetAllAsync();
        }


        private void btnDisposal_Click(object sender, EventArgs e)
        {
            DeleteOneKeeping();
        }


        internal void DeleteOneKeeping()
        {
            Warehouse warehouse = warehouseBindingSource.Current as Warehouse;

            if (warehouse == null)
                return;
            if (Helpers.DeleteHelper.SureToDelete() == false)
                return;

            warehouse.Count = 0;

            DataRepository.Warehouse.Update(warehouse);

        }

        private void uscSearch_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {

            lkuWarehouseName.EditValue = null;

        }

        private void uscSearch_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
            warehouseBindingSource.DataSource = DataRepository.Warehouse.Searchby((int?)lkuWarehouseName.EditValue);
        }


    }
}
