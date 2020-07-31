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
    public partial class InsertInspectionForm : ChildRootForm
    {
        private InspectionResult _inspectionResult;
        private Inspection _inspection;
        private Product _product;
        
       
        public InsertInspectionForm()
        {
            InitializeComponent(); 
        }

        public InsertInspectionForm(Product product) : this()
        {
            _product = product;
        }

        protected async override void OnShown(EventArgs e)
        {
            //base.OnShown(e);
            bdsTeam.DataSource = await DataRepository.Team.GetAllAsync();
            bdsWarehouse.DataSource = await DataRepository.Warehouse.GetAllAsync();
        }

        protected override void btnAction_Click(object sender, EventArgs e)
        {
            //Helpers.WarehouseId.warehouseId = (int)cbbWarehouseName.SelectedValue;
            _inspectionResult = new InspectionResult();
            _inspection = new Inspection();
            WriteToEntity();
            try
            {
                DataRepository.Inspection.Insert(_inspection);
                DataRepository.InspectionResult.Insert(_inspectionResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("작업시시 했습니다.");
            Close();
        }

       
        private void WriteToEntity()
        {
            _inspection.InspectionId = DataRepository.Inspection.GetMaxId() + 1;
            _inspection.InspectionTeam = (int)lueTeamName.EditValue;
            _inspection.StartTime = DateTime.Now;
            _inspection.FinishTime = null;

            _inspectionResult.InspectionResultId = DataRepository.InspectionResult.GetMaxId() + 1;
            _inspectionResult.InspectionId = _inspection.InspectionId;
            _inspectionResult.ProductId = _product.ProductId;
            _inspectionResult.Count = 0;
            _inspectionResult.NormalNumber = 0;
            _inspectionResult.DefectiveNumber = 0;

            //_inspectionResult.InspectionId = (int)cbbTeamName.SelectedValue;
            //_Inspection.WarehouseId = (int)cbbWarehouseName.SelectedValue;
        }
    }
}
