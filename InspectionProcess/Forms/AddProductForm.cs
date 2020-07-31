using DevExpress.XtraEditors;
using InspectionProcess.Data;
using InspectionProcess.Forms.UpdateForms;
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
    public partial class AddProductForm : XtraForm
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //bdsProduct.DataSource = DataRepository.Product.GetAll();
            bdsMerchandise.DataSource = await DataRepository.Merchandise.GetAllAsync();
            bdsTeam.DataSource = await DataRepository.Team.GetAllAsync();
  
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertProductForm form = new InsertProductForm();
            form.ShowDialog();
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Product product = bdsProduct.Current as Product;
            if (product == null)
                return;
            UpdateProductForm form = new UpdateProductForm(product);
            
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product product = bdsProduct.Current as Product;
            if (product == null)
                return;
            if (Helpers.DeleteHelper.SureToDelete() == false)
                return;
            DataRepository.Product.Delete(product);
            bdsProduct.Remove(product);
        }

        private void searchButtonControl1_ResetButtonClicked(object sender, UserControls.SearchButtonControl.ResetButtonClickedEventArgs e)
        {
            lueMerchandiseName.EditValue = null;
            lueTeam.EditValue = null;
        }

        private void searchButtonControl1_SearchButtonClicked(object sender, UserControls.SearchButtonControl.SearchButtonClickedEventArgs e)
        {
            int? merchandiseId = (int?)lueMerchandiseName.EditValue;
            int? teamId = (int?)lueTeam.EditValue;

            bdsProduct.DataSource = DataRepository.Product.Search(null, merchandiseId, teamId);
        }
    }
}
