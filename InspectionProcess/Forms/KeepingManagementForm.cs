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
    public partial class KeepingManagementForm : XtraForm
    {
        public KeepingManagementForm()
        {
            InitializeComponent();
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //TODO : Asynchrous Method로 변경
            bdsWarehouse.DataSource = await DataRepository.Warehouse.GetAllAsync();
            bdsMerchandise.DataSource = await DataRepository.Merchandise.GetAllAsync();
           
        }



      

        private void uscSearch_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
          
            bdsKeeping.DataSource = DataRepository.Keeping.Search((int?)lkuWarehouse.EditValue, (DateTime?)dteKeepFrom.EditValue, (DateTime?)dteKeepTo.EditValue);
        }

        private void uscSearch_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {
            //TODO : LookUpEdit로 변경
            lkuWarehouse.EditValue = null;
            dteKeepFrom.EditValue = null;
            dteKeepTo.EditValue = null;
        }

     
    }
}
