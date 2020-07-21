namespace InspectionProcess.Forms
{
    partial class InsertInspectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbbInspectionId = new System.Windows.Forms.ComboBox();
            this.bdsInspection = new System.Windows.Forms.BindingSource(this.components);
            this.cbbWarehouseName = new System.Windows.Forms.ComboBox();
            this.bdsWarehouse = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbInspectionId);
            this.layoutControl1.Controls.Add(this.cbbWarehouseName);
            this.layoutControl1.Size = new System.Drawing.Size(552, 247);
            this.layoutControl1.Controls.SetChildIndex(this.cbbWarehouseName, 0);
            this.layoutControl1.Controls.SetChildIndex(this.cbbInspectionId, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnInsert, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.Root.Size = new System.Drawing.Size(552, 247);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem1.Size = new System.Drawing.Size(532, 136);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 196);
            this.emptySpaceItem2.Size = new System.Drawing.Size(312, 31);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(324, 208);
            this.btnInsert.Size = new System.Drawing.Size(105, 27);
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 208);
            this.btnClose.Size = new System.Drawing.Size(107, 27);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(421, 196);
            this.layoutControlItem2.Size = new System.Drawing.Size(111, 31);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(312, 196);
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 31);
            // 
            // cbbInspectionId
            // 
            this.cbbInspectionId.DataSource = this.bdsInspection;
            this.cbbInspectionId.DisplayMember = "InspectionTeam";
            this.cbbInspectionId.FormattingEnabled = true;
            this.cbbInspectionId.Location = new System.Drawing.Point(79, 12);
            this.cbbInspectionId.Name = "cbbInspectionId";
            this.cbbInspectionId.Size = new System.Drawing.Size(461, 26);
            this.cbbInspectionId.TabIndex = 5;
            this.cbbInspectionId.ValueMember = "InspectionTeam";
            // 
            // bdsInspection
            // 
            this.bdsInspection.DataSource = typeof(InspectionProcess.Data.Inspection);
            // 
            // cbbWarehouseName
            // 
            this.cbbWarehouseName.DataSource = this.bdsWarehouse;
            this.cbbWarehouseName.DisplayMember = "Name";
            this.cbbWarehouseName.FormattingEnabled = true;
            this.cbbWarehouseName.Location = new System.Drawing.Point(79, 42);
            this.cbbWarehouseName.Name = "cbbWarehouseName";
            this.cbbWarehouseName.Size = new System.Drawing.Size(461, 26);
            this.cbbWarehouseName.TabIndex = 5;
            this.cbbWarehouseName.ValueMember = "WarehouseId";
            // 
            // bdsWarehouse
            // 
            this.bdsWarehouse.DataSource = typeof(InspectionProcess.Data.Warehouse);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbInspectionId;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "검사조ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(532, 30);
            this.layoutControlItem1.Text = "검사조ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbWarehouseName;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "창고명";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(532, 30);
            this.layoutControlItem4.Text = "창고명";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 18);
            // 
            // InsertInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 247);
            this.Name = "InsertInspectionForm";
            this.Text = "II";
            this.Load += new System.EventHandler(this.InsertInspectionForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbInspectionId;
        private System.Windows.Forms.ComboBox cbbWarehouseName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdsInspection;
        private System.Windows.Forms.BindingSource bdsWarehouse;
    }
}