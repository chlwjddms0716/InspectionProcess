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
            cbbMerchandise.SelectedItem = null;
            cbbWarehouseName.SelectedItem = null;
        }


        private void DisposalManagementForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsKeeping.DataSource = DataRepository.Keeping.Searchby((int?)cbbWarehouseName.SelectedValue, (DateTime?)dteKeepFrom.EditValue, (DateTime?)dteKeepTo.EditValue);
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
    }
}
