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
    public partial class InsertProductForm : Form
    {
        private Product _Product;
        public InsertProductForm()
        {
            InitializeComponent();
        }


        public InsertProductForm(Product product) : this()
        {
            _product = product;
        }

        private void InsertProductForm_Load(object sender, EventArgs e)
        {
            bdsMerchandise.DataSource = DataRepository.Merchandise.GetAll();
           
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            _product = new Product();
            WriteToEntity();
            try
            {
                DataRepository.Product.Insert(_product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
