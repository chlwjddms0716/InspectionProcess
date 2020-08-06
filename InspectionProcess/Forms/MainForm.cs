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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnProduce_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AddProductForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            AddProductForm addProductForm = new AddProductForm();
            addProductForm.MdiParent = this;
            addProductForm.WindowState = FormWindowState.Maximized;
            addProductForm.Show();
        }

        private void btnWorking_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ProductManagementForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            ProductManagementForm productManagamentForm = new ProductManagementForm();
            productManagamentForm.MdiParent = this;
            productManagamentForm.WindowState = FormWindowState.Maximized;
            productManagamentForm.Show();
        }

        private void btnNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(QualityManagementForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            QualityManagementForm qualityManagementForm = new QualityManagementForm();
            qualityManagementForm.MdiParent = this;
            qualityManagementForm.WindowState = FormWindowState.Maximized;
            qualityManagementForm.Show();
        }

        private void btnKeep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(KeepingManagementForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            KeepingManagementForm keepingManagementForm = new KeepingManagementForm();
            keepingManagementForm.MdiParent = this;
            keepingManagementForm.WindowState = FormWindowState.Maximized;
            keepingManagementForm.Show();
        }

        private void btnDump_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(WarehouseManagementForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            WarehouseManagementForm disposalManagementForm = new WarehouseManagementForm();
            disposalManagementForm.MdiParent = this;
            disposalManagementForm.WindowState = FormWindowState.Maximized;
            disposalManagementForm.Show();
        }

        private void btnMachine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FacilityManagementForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            FacilityManagementForm facilityManagementForm = new FacilityManagementForm();
            facilityManagementForm.MdiParent = this;
            facilityManagementForm.WindowState = FormWindowState.Maximized;
            facilityManagementForm.Show();
        }

        private void btnStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(RealTimeStatusForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            RealTimeStatusForm realTimeStatusForm = new RealTimeStatusForm();
            realTimeStatusForm.MdiParent = this;
            realTimeStatusForm.WindowState = FormWindowState.Maximized;
            realTimeStatusForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(RealTimeStatusForm))
                {
                    frm.Activate();
                    frm.BringToFront();
                    return;
                }
            }

            RealTimeStatusForm realTimeStatusForm = new RealTimeStatusForm();
            realTimeStatusForm.MdiParent = this;
            realTimeStatusForm.WindowState = FormWindowState.Maximized;
            realTimeStatusForm.Show();
        }
    }
}

