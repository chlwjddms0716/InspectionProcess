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


    private void InsertInspectionForm_Load(object sender, EventArgs e)
        {
            bdsInspection.DataSource = DataRepository.Inspection.GetAll();
            bdsWarehouse.DataSource = DataRepository.Warehouse.GetAll();

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            _inspection = new Inspection();
            WriteToEntity();
            try
            {
                DataRepository.Inspection.Insert(_inspection);
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
