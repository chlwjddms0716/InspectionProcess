using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess
{
    public partial class ChildRootForm : XtraForm
    {
        public ChildRootForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Register();

        }

        protected virtual void Register()
        {
            throw new NotImplementedException();
        }
    }
}
