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

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void btnAction_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
