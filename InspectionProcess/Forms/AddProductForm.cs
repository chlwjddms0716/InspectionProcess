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
            cbbMerchandiseName.SelectedItem = null;
            cbbTeam.SelectedItem = null;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int? merchandiseId = (int?)cbbMerchandiseName.SelectedValue;
            int? teamId = (int?)cbbTeam.SelectedValue;

            bdsProduct.DataSource = DataRepository.Product.Search(null, merchandiseId, teamId);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertProductForm form = new InsertProductForm();
            form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cbbMerchandiseName.SelectedItem = null;
            cbbTeam.SelectedItem = null;
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
    }
}
