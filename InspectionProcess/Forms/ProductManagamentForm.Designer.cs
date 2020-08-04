namespace InspectionProcess.Forms
{
    partial class ProductManagementForm
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
            this.lkuProductionId = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsProductId = new System.Windows.Forms.BindingSource(this.components);
            this.lkuMerchandiseName = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.searchButtonControl1 = new InspectionProcess.UserControls.SearchButtonControl();
            this.btnInstruction = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMerchandiseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuProductionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMerchandiseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lkuProductionId);
            this.layoutControl1.Controls.Add(this.lkuMerchandiseName);
            this.layoutControl1.Controls.Add(this.searchButtonControl1);
            this.layoutControl1.Controls.Add(this.btnInstruction);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 507);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lkuProductionId
            // 
            this.lkuProductionId.Location = new System.Drawing.Point(57, 12);
            this.lkuProductionId.Name = "lkuProductionId";
            this.lkuProductionId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuProductionId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductId", "Name1")});
            this.lkuProductionId.Properties.DataSource = this.bdsProductId;
            this.lkuProductionId.Properties.DisplayMember = "ProductId";
            this.lkuProductionId.Properties.ValueMember = "ProductId";
            this.lkuProductionId.Size = new System.Drawing.Size(577, 24);
            this.lkuProductionId.StyleController = this.layoutControl1;
            this.lkuProductionId.TabIndex = 14;
            // 
            // bdsProductId
            // 
            this.bdsProductId.DataSource = typeof(InspectionProcess.Data.Product);
            // 
            // lkuMerchandiseName
            // 
            this.lkuMerchandiseName.Location = new System.Drawing.Point(57, 40);
            this.lkuMerchandiseName.Name = "lkuMerchandiseName";
            this.lkuMerchandiseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuMerchandiseName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name2")});
            this.lkuMerchandiseName.Properties.DataSource = this.bdsMerchandise;
            this.lkuMerchandiseName.Properties.DisplayMember = "Name";
            this.lkuMerchandiseName.Properties.ValueMember = "MerchandiseId";
            this.lkuMerchandiseName.Size = new System.Drawing.Size(577, 24);
            this.lkuMerchandiseName.StyleController = this.layoutControl1;
            this.lkuMerchandiseName.TabIndex = 13;
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
            // 
            // searchButtonControl1
            // 
            this.searchButtonControl1.Location = new System.Drawing.Point(638, 12);
            this.searchButtonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButtonControl1.Name = "searchButtonControl1";
            this.searchButtonControl1.Size = new System.Drawing.Size(150, 52);
            this.searchButtonControl1.TabIndex = 12;
            this.searchButtonControl1.SearchButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.SearchButtonClickedEventArgs>(this.searchButtonControl1_SearchButtonClicked);
            this.searchButtonControl1.ResetButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.ResetButtonClickedEventArgs>(this.searchButtonControl1_ResetButtonClicked);
            // 
            // btnInstruction
            // 
            this.btnInstruction.Location = new System.Drawing.Point(633, 468);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(155, 27);
            this.btnInstruction.StyleController = this.layoutControl1;
            this.btnInstruction.TabIndex = 11;
            this.btnInstruction.Text = "작업지시";
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsProduct;
            this.gridControl1.Location = new System.Drawing.Point(12, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 396);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(InspectionProcess.Data.Product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colMerchandiseName,
            this.colFinishTime,
            this.colProductionTeam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductId
            // 
            this.colProductId.Caption = "생산품ID";
            this.colProductId.FieldName = "ProductId";
            this.colProductId.MinWidth = 25;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 1;
            this.colProductId.Width = 94;
            // 
            // colMerchandiseName
            // 
            this.colMerchandiseName.Caption = "상품명";
            this.colMerchandiseName.FieldName = "MerchandiseName";
            this.colMerchandiseName.MinWidth = 25;
            this.colMerchandiseName.Name = "colMerchandiseName";
            this.colMerchandiseName.Visible = true;
            this.colMerchandiseName.VisibleIndex = 0;
            this.colMerchandiseName.Width = 94;
            // 
            // colFinishTime
            // 
            this.colFinishTime.Caption = "종료시간";
            this.colFinishTime.DisplayFormat.FormatString = "d";
            this.colFinishTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFinishTime.FieldName = "FinishTime";
            this.colFinishTime.MinWidth = 25;
            this.colFinishTime.Name = "colFinishTime";
            this.colFinishTime.Visible = true;
            this.colFinishTime.VisibleIndex = 3;
            this.colFinishTime.Width = 94;
            // 
            // colProductionTeam
            // 
            this.colProductionTeam.Caption = "검사조";
            this.colProductionTeam.FieldName = "ProductionTeam";
            this.colProductionTeam.MinWidth = 25;
            this.colProductionTeam.Name = "colProductionTeam";
            this.colProductionTeam.Visible = true;
            this.colProductionTeam.VisibleIndex = 2;
            this.colProductionTeam.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 507);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 400);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 456);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(621, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnInstruction;
            this.layoutControlItem6.Location = new System.Drawing.Point(621, 456);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(159, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.searchButtonControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(626, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(154, 56);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lkuMerchandiseName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(626, 28);
            this.layoutControlItem2.Text = "상품명";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(42, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lkuProductionId;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(626, 28);
            this.layoutControlItem3.Text = "생산ID";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(42, 18);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductManagementForm";
            this.Text = "작업관리";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkuProductionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuMerchandiseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.BindingSource bdsProductId;
        private System.Windows.Forms.BindingSource bdsProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colMerchandiseName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishTime;
        private DevExpress.XtraEditors.SimpleButton btnInstruction;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private UserControls.SearchButtonControl searchButtonControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit lkuProductionId;
        private DevExpress.XtraEditors.LookUpEdit lkuMerchandiseName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}