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
    public partial class KeepingManagementForm : XtraForm
    {
        public KeepingManagementForm()
        {
            InitializeComponent();
        }

        private void KeepingManagementForm_Load(object sender, EventArgs e)
        {         
            cbbWarehouse.DataSource = DataRepository.Warehouse.GetAll();
            cbbMerchandiseName.DataSource = DataRepository.Merchandise.GetAll();
            cbbMerchandiseName.SelectedItem = null;
            cbbWarehouse.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsKeeping.DataSource = DataRepository.Keeping.Search((int?)cbbWarehouse.SelectedValue, (DateTime?)dteKeepFrom.EditValue, (DateTime?)dteKeepTo.EditValue);
            
        }
    }
}
