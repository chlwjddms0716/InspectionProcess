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
    // 검사조 추가
    public partial class ProductManagementForm : XtraForm
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }
        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bdsProductId.DataSource = await DataRepository.Product.GetAllAsync();
            bdsMerchandise.DataSource = await DataRepository.Merchandise.GetAllAsync();

        }


        private void btnInstruction_Click(object sender, EventArgs e)
        {
            Product product = bdsProduct.Current as Product;
            if (product == null)
                return;
            InsertInspectionForm form = new InsertInspectionForm(product);
            form.ShowDialog();
            
        }

        private void searchButtonControl1_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {
            lkuMerchandiseName.EditValue = null;
            lkuProductionId.EditValue = null;
        }

        private void searchButtonControl1_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
            bdsProduct.DataSource = DataRepository.Product.Search((int?)lkuProductionId.EditValue, (int?)lkuMerchandiseName.EditValue, null);
        }
    }
}
