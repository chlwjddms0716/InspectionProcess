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
        private Inspection _Inspection;


        public InsertInspectionForm()
        {
            InitializeComponent();
        }

        public InsertInspectionForm(Inspection inspection) : this()
        {
            _Inspection = inspection;
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertInspectionForm_Load_1(object sender, EventArgs e)
        {
            bdsInspection.DataSource = DataRepository.Inspection.GetAll();
            bdsWarehouse.DataSource = DataRepository.Warehouse.GetAll();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {

            WriteToEntity();
            try
            {
                DataRepository.Inspection.Insert(_Inspection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void WriteToEntity()
        {
            _Inspection.InspectionId = (int)cbbInspectionId.SelectedValue;
            //_Inspection.WarehouseId = (int)cbbWarehouseName.SelectedValue;
        }
    }
}
