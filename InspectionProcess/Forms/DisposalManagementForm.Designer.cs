namespace InspectionProcess.Forms
{
    partial class DisposalManagementForm
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
            this.lkuWarehouseName = new DevExpress.XtraEditors.LookUpEdit();
            this.lkuMerchandise = new DevExpress.XtraEditors.LookUpEdit();
            this.uscSearch = new InspectionProcess.UserControls.SearchButtonControl();
            this.btnDisposal = new DevExpress.XtraEditors.SimpleButton();
            this.bdsWarehouse = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsKeeping = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeepingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteKeepTo = new DevExpress.XtraEditors.DateEdit();
            this.dteKeepFrom = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuWarehouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMerchandise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKeeping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lkuWarehouseName);
            this.layoutControl1.Controls.Add(this.lkuMerchandise);
            this.layoutControl1.Controls.Add(this.uscSearch);
            this.layoutControl1.Controls.Add(this.btnDisposal);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.dteKeepTo);
            this.layoutControl1.Controls.Add(this.dteKeepFrom);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 546);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lkuWarehouseName
            // 
            this.lkuWarehouseName.Location = new System.Drawing.Point(311, 12);
            this.lkuWarehouseName.Name = "lkuWarehouseName";
            this.lkuWarehouseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuWarehouseName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name7")});
            this.lkuWarehouseName.Properties.DataSource = this.bdsWarehouse;
            this.lkuWarehouseName.Properties.DisplayMember = "Name";
            this.lkuWarehouseName.Properties.ValueMember = "WarehouseId";
            this.lkuWarehouseName.Size = new System.Drawing.Size(239, 24);
            this.lkuWarehouseName.StyleController = this.layoutControl1;
            this.lkuWarehouseName.TabIndex = 9;
            // 
            // lkuMerchandise
            // 
            this.lkuMerchandise.Location = new System.Drawing.Point(67, 12);
            this.lkuMerchandise.Name = "lkuMerchandise";
            this.lkuMerchandise.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuMerchandise.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name6")});
            this.lkuMerchandise.Properties.DataSource = this.bdsMerchandise;
            this.lkuMerchandise.Properties.DisplayMember = "Name";
            this.lkuMerchandise.Properties.ValueMember = "MerchandiseId";
            this.lkuMerchandise.Size = new System.Drawing.Size(185, 24);
            this.lkuMerchandise.StyleController = this.layoutControl1;
            this.lkuMerchandise.TabIndex = 8;
            // 
            // uscSearch
            // 
            this.uscSearch.Location = new System.Drawing.Point(635, 12);
            this.uscSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(153, 52);
            this.uscSearch.TabIndex = 3;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.SearchButtonClickedEventArgs>(this.uscSearch_SearchButtonClicked);
            this.uscSearch.ResetButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.ResetButtonClickedEventArgs>(this.uscSearch_ResetButtonClicked);
            // 
            // btnDisposal
            // 
            this.btnDisposal.Location = new System.Drawing.Point(627, 507);
            this.btnDisposal.Name = "btnDisposal";
            this.btnDisposal.Size = new System.Drawing.Size(161, 27);
            this.btnDisposal.StyleController = this.layoutControl1;
            this.btnDisposal.TabIndex = 7;
            this.btnDisposal.Text = "폐기(&S)";
            this.btnDisposal.Click += new System.EventHandler(this.btnDisposal_Click);
            // 
            // bdsWarehouse
            // 
            this.bdsWarehouse.DataSource = typeof(InspectionProcess.Data.Warehouse);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsKeeping;
            this.gridControl1.Location = new System.Drawing.Point(12, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 435);
            this.gridControl1.TabIndex = 6;
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
            // dteKeepTo
            // 
            this.dteKeepTo.EditValue = null;
            this.dteKeepTo.Location = new System.Drawing.Point(416, 40);
            this.dteKeepTo.Name = "dteKeepTo";
            this.dteKeepTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteKeepTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteKeepTo.Size = new System.Drawing.Size(134, 24);
            this.dteKeepTo.StyleController = this.layoutControl1;
            this.dteKeepTo.TabIndex = 5;
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
            this.dteKeepFrom.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.emptySpaceItem4,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 546);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dteKeepFrom;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(349, 28);
            this.layoutControlItem3.Text = "입고날짜";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dteKeepTo;
            this.layoutControlItem4.Location = new System.Drawing.Point(349, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(193, 28);
            this.layoutControlItem4.Text = "~";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 439);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(542, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(81, 56);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 495);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(615, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnDisposal;
            this.layoutControlItem2.Location = new System.Drawing.Point(615, 495);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(165, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.uscSearch;
            this.layoutControlItem7.Location = new System.Drawing.Point(623, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(157, 56);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lkuMerchandise;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(244, 28);
            this.layoutControlItem8.Text = "상품명";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lkuWarehouseName;
            this.layoutControlItem5.Location = new System.Drawing.Point(244, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(298, 28);
            this.layoutControlItem5.Text = "창고명";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 18);
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
            // 
            // DisposalManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::InspectionProcess.Properties.Resources.KakaoTalk_20200722_115827447;
            this.Name = "DisposalManagementForm";
            this.Text = "폐기관리";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkuWarehouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMerchandise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKeeping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteKeepFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit dteKeepFrom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnDisposal;
        private System.Windows.Forms.BindingSource bdsWarehouse;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.BindingSource bdsKeeping;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colKeepingDate;
        private DevExpress.XtraEditors.DateEdit dteKeepTo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private UserControls.SearchButtonControl uscSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit lkuWarehouseName;
        private DevExpress.XtraEditors.LookUpEdit lkuMerchandise;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}