using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess.Helpers
{
    public static class DeleteHelper
    {
        public static bool SureToDelete()
        {

            return XtraMessageBox.Show(
                    "삭제하시겠습니까?",
                    "질문",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes;
        }
    }
}
