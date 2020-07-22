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

namespace InspectionProcess.Forms.UpdateForms
{
    public partial class UpdateProductForm : ChildRootForm
    {
        private Product _product;
        public UpdateProductForm()
        {
            InitializeComponent();
        }
        public UpdateProductForm(Product product) : this()
        {
            _product = product;
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            bdsMerchandise.DataSource = DataRepository.Merchandise.GetAll();
            bdsTeam.DataSource = DataRepository.Team.GetAll();

            txeProductId.Text = _product.ProductId.ToString();
            cbbMerchandiseName.SelectedItem = _product.MerchandiseId;
            cbbTeamName.SelectedItem = _product.ProductionTeam;
            dteFinishDate.EditValue = _product.FinishTime;
            teFinishTime.EditValue = _product.FinishTime;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            WriteToEntity();
            try
            {
                DataRepository.Product.Update(_product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void WriteToEntity()
        {
            _product.MerchandiseId = (int)cbbMerchandiseName.SelectedValue;
            _product.ProductionTeam = (int)cbbTeamName.SelectedValue;
            _product.FinishTime = (DateTime)dteFinishDate.EditValue;

            _product.FinishTime = _product.FinishTime.AddHours(((DateTime)teFinishTime.EditValue).Hour);
            _product.FinishTime = _product.FinishTime.AddMinutes(((DateTime)teFinishTime.EditValue).Minute);
            _product.FinishTime = _product.FinishTime.AddSeconds(((DateTime)teFinishTime.EditValue).Second);
        }
    }
}
