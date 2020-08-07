using InspectionProcess.Data;
using InspectionProcess.Helpers;
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
        private InspectionResult __inspectionResult;
        private Inspection _inspection;
        private Inspection __inspection;
        private Product _product;

        public InsertInspectionForm()
        {
            InitializeComponent(); 
        }

        public InsertInspectionForm(Product product) : this()
        {
            _product = product;
        }

        public InsertInspectionForm(InspectionResult inspectionResult) : this()
        {
            __inspectionResult = inspectionResult;
        }

        protected async override void OnShown(EventArgs e)
        {
            //base.OnShown(e);
            bdsTeam.DataSource = await DataRepository.Team.GetAllAsync();
            bdsWarehouse.DataSource = await DataRepository.Warehouse.GetAllAsync();
        }

        protected override void btnAction_Click(object sender, EventArgs e)
        {
            if (__inspectionResult.ProductId == DataRepository.Product.GetbyId(__inspectionResult.ProductId))
            {
                __inspectionResult.Count += 1;

                if (__inspectionResult.InspectionId == DataRepository.Inspection.GetbyId(__inspectionResult.InspectionId))
                {
                    __inspection = DataRepository.Inspection.Get(__inspectionResult.InspectionId);
                    __inspection.InspectionTeam = (int)lueTeamName.EditValue;
                }
                
                DataRepository.InspectionResult.Update(__inspectionResult);
                DataRepository.Inspection.Update(__inspection);

                MessageBox.Show("작업지시 했습니다.");

                JobQueue.Instance.AddList(__inspectionResult.InspectionResultId, __inspection.InspectionId);
                Close();
            }
            else
            {
                _inspectionResult = new InspectionResult();
                _inspection = new Inspection();
                //Helpers.WarehouseId.warehouseId = (int)cbbWarehouseName.SelectedValue;

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
                MessageBox.Show("작업지시 했습니다.");

                JobQueue.Instance.AddList(_inspectionResult.InspectionResultId, _inspection.InspectionId);

                Close();
            }
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
