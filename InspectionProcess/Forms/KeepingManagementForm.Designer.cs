namespace InspectionProcess.Forms
{
    partial class KeepingManagementForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lkuMerchandiseName = new DevExpress.XtraEditors.LookUpEdit();
            this.uscSearch = new InspectionProcess.UserControls.SearchButtonControl();
            this.bdsWarehouse = new System.Windows.Forms.BindingSource(this.components);
            this.dteKeepTo = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsKeeping = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeepingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteKeepFrom = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.lkuWarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMerchandiseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKeeping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lkuWarehouse);
            this.layoutControl1.Controls.Add(this.lkuMerchandiseName);
            this.layoutControl1.Controls.Add(this.uscSearch);
            this.layoutControl1.Controls.Add(this.dteKeepTo);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dteKeepFrom);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1067, 123, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(885, 577);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lkuMerchandiseName
            // 
            this.lkuMerchandiseName.Location = new System.Drawing.Point(67, 12);
            this.lkuMerchandiseName.Name = "lkuMerchandiseName";
            this.lkuMerchandiseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuMerchandiseName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name4")});
            this.lkuMerchandiseName.Properties.DataSource = this.bdsMerchandise;
            this.lkuMerchandiseName.Properties.DisplayMember = "Name";
            this.lkuMerchandiseName.Properties.ValueMember = "MerchandiseId";
            this.lkuMerchandiseName.Size = new System.Drawing.Size(290, 24);
            this.lkuMerchandiseName.StyleController = this.layoutControl1;
            this.lkuMerchandiseName.TabIndex = 16;
            // 
            // uscSearch
            // 
            this.uscSearch.Location = new System.Drawing.Point(724, 12);
            this.uscSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(149, 52);
            this.uscSearch.TabIndex = 15;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.SearchButtonClickedEventArgs>(this.uscSearch_SearchButtonClicked);
            this.uscSearch.ResetButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.ResetButtonClickedEventArgs>(this.uscSearch_ResetButtonClicked);
            // 
            // bdsWarehouse
            // 
            this.bdsWarehouse.DataSource = typeof(InspectionProcess.Data.Warehouse);
            // 
            // dteKeepTo
            // 
            this.dteKeepTo.EditValue = null;
            this.dteKeepTo.Location = new System.Drawing.Point(416, 40);
            this.dteKeepTo.Name = "dteKeepTo";
            this.dteKeepTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteKeepTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteKeepTo.Size = new System.Drawing.Size(304, 24);
            this.dteKeepTo.StyleController = this.layoutControl1;
            this.dteKeepTo.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsKeeping;
            this.gridControl1.Location = new System.Drawing.Point(12, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(861, 497);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsKeeping
            // 
            this.bdsKeeping.DataSource = typeof(InspectionProcess.Data.Keeping);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWarehouseName,
            this.colCount,
            this.colKeepingDate,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colWarehouseName
            // 
            this.colWarehouseName.FieldName = "WarehouseName";
            this.colWarehouseName.MinWidth = 25;
            this.colWarehouseName.Name = "colWarehouseName";
            this.colWarehouseName.Visible = true;
            this.colWarehouseName.VisibleIndex = 1;
            this.colWarehouseName.Width = 94;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.MinWidth = 25;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 2;
            this.colCount.Width = 94;
            // 
            // colKeepingDate
            // 
            this.colKeepingDate.FieldName = "KeepingDate";
            this.colKeepingDate.MinWidth = 25;
            this.colKeepingDate.Name = "colKeepingDate";
            this.colKeepingDate.Visible = true;
            this.colKeepingDate.VisibleIndex = 3;
            this.colKeepingDate.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "검사ID";
            this.gridColumn1.FieldName = "KeepInspectionId";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // dteKeepFrom
            // 
            this.dteKeepFrom.EditValue = null;
            this.dteKeepFrom.Location = new System.Drawing.Point(67, 40);
            this.dteKeepFrom.Name = "dteKeepFrom";
            this.dteKeepFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteKeepFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteKeepFrom.Size = new System.Drawing.Size(290, 24);
            this.dteKeepFrom.StyleController = this.layoutControl1;
            this.dteKeepFrom.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(885, 577);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dteKeepFrom;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(349, 28);
            this.layoutControlItem6.Text = "입고날짜";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(865, 501);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dteKeepTo;
            this.layoutControlItem4.Location = new System.Drawing.Point(349, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(363, 28);
            this.layoutControlItem4.Text = "~";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.uscSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(712, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(153, 56);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lkuMerchandiseName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(349, 28);
            this.layoutControlItem3.Text = "상품명";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
            // 
            // lkuWarehouse
            // 
            this.lkuWarehouse.Location = new System.Drawing.Point(416, 12);
            this.lkuWarehouse.Name = "lkuWarehouse";
            this.lkuWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuWarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name5")});
            this.lkuWarehouse.Properties.DataSource = this.bdsWarehouse;
            this.lkuWarehouse.Properties.DisplayMember = "Name";
            this.lkuWarehouse.Properties.ValueMember = "WarehouseId";
            this.lkuWarehouse.Size = new System.Drawing.Size(304, 24);
            this.lkuWarehouse.StyleController = this.layoutControl1;
            this.lkuWarehouse.TabIndex = 17;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lkuWarehouse;
            this.layoutControlItem1.Location = new System.Drawing.Point(349, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(363, 28);
            this.layoutControlItem1.Text = "창고명";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 18);
            // 
            // KeepingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 577);
            this.Controls.Add(this.layoutControl1);
            this.Name = "KeepingManagementForm";
            this.Text = "입고관리";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkuMerchandiseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKeeping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dteKeepFrom;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bdsWarehouse;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private DevExpress.XtraEditors.DateEdit dteKeepTo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdsKeeping;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colKeepingDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private UserControls.SearchButtonControl uscSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lkuMerchandiseName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lkuWarehouse;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}