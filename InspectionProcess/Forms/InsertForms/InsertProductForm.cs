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

        protected async override void OnShown(EventArgs e)
        {
            //base.OnShown(e);
            bdsMerchandise.DataSource = await DataRepository.Merchandise.GetAllAsync();
            bdsProductionTeamId.DataSource = await DataRepository.Product.GetAllAsync();
            bdsTeam.DataSource = await DataRepository.Team.GetAllAsync();
        }

        protected override void btnAction_Click(object sender, EventArgs e)
        {
            _product = new Product();
            WriteToEntity();

            try
            {
                DataRepository.Product.Insert(_product);
                MessageBox.Show("등록되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        //protected override void btnAction_Click(object sender, EventArgs e)
        //{

        //}

        private void WriteToEntity()
        {
            _product.ProductId = DataRepository.Product.GetMaxId() + 1;

            _product.MerchandiseId = (int)lueMerchandise.EditValue;

            _product.FinishTime = (DateTime)dteFinishDate.EditValue;

            _product.FinishTime = _product.FinishTime.AddHours(((DateTime)teFinishTime.EditValue).Hour);
            _product.FinishTime = _product.FinishTime.AddMinutes(((DateTime)teFinishTime.EditValue).Minute);
            _product.FinishTime = _product.FinishTime.AddSeconds(((DateTime)teFinishTime.EditValue).Second);

            _product.ProductionTeam = (int)lueProductionTeamId.EditValue; 
        }
    }
}

