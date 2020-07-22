using System;
using InspectionProcess.Data;
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
    public partial class InsertProductForm : ChildRootForm
    {
        private Product _product;
        private object cbbMerchandiseId;

        public InsertProductForm()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void InsertProductForm_Load(object sender, EventArgs e)
        {
            bdsMerchandise.DataSource = DataRepository.Merchandise.GetAll();
            bdsProductionTeamId.DataSource = DataRepository.Product.GetAll();
            bdsTeam.DataSource = DataRepository.Team.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
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

        private void WriteToEntity()
        {
            _product.MerchandiseId = (int)cbbMerchandise.SelectedValue;
            _product.FinishTime = (DateTime)dteFinishDate.EditValue;
            //_product.FinishTime =  (DateTime)teFinishTime.EditValue;
            _product.ProductionTeam = (int)cbbProductionTeamId.SelectedValue;
        }
    }
}

