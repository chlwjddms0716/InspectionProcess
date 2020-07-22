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
    public partial class ProductManagementForm : XtraForm
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            bdsProductId.DataSource = DataRepository.Product.GetAll();
            bdsMerchandise.DataSource = DataRepository.Merchandise.GetAll();
            cbbMerchandiseName.SelectedItem = null;
            cbbProductionId.SelectedItem = null;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bdsProduct.DataSource = DataRepository.Product.Search((int?)cbbProductionId.SelectedValue,(int?)cbbMerchandiseName.SelectedValue, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbMerchandiseName.SelectedItem = null;
            cbbProductionId.SelectedItem = null;
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            Product product = bdsProduct.Current as Product;
            if (product == null)
                return;
            InsertInspectionForm form = new InsertInspectionForm(product);
            form.ShowDialog();
            
        }
    }
}
