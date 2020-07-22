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
    public partial class AddProductForm : XtraForm
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            //bdsProduct.DataSource = DataRepository.Product.GetAll();
            bdsMerchandise.DataSource = DataRepository.Merchandise.GetAll();
            bdsTeam.DataSource = DataRepository.Team.GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int merchandiseId = (int)cbbMerchandiseName.SelectedValue;
            int teamId = (int)cbbTeam.SelectedValue;

            bdsProduct.DataSource = DataRepository.Product.Search(null, merchandiseId, teamId);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertProductForm form = new InsertProductForm();
            form.ShowDialog();
        }
    }
}
