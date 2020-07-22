namespace InspectionProcess.Forms
{
    partial class AddProductForm
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
            this.cbbTeam = new System.Windows.Forms.ComboBox();
            this.bdsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMerchandiseName = new System.Windows.Forms.ComboBox();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMerchandiseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbTeam);
            this.layoutControl1.Controls.Add(this.cbbMerchandiseName);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnInsert);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(978, 551);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbTeam
            // 
            this.cbbTeam.DataSource = this.bdsTeam;
            this.cbbTeam.DisplayMember = "Name";
            this.cbbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTeam.FormattingEnabled = true;
            this.cbbTeam.Location = new System.Drawing.Point(54, 42);
            this.cbbTeam.Name = "cbbTeam";
            this.cbbTeam.Size = new System.Drawing.Size(370, 26);
            this.cbbTeam.TabIndex = 10;
            this.cbbTeam.ValueMember = "TeamId";
            // 
            // bdsTeam
            // 
            this.bdsTeam.DataSource = typeof(InspectionProcess.Data.Team);
            // 
            // cbbMerchandiseName
            // 
            this.cbbMerchandiseName.DataSource = this.bdsMerchandise;
            this.cbbMerchandiseName.DisplayMember = "Name";
            this.cbbMerchandiseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMerchandiseName.FormattingEnabled = true;
            this.cbbMerchandiseName.Location = new System.Drawing.Point(54, 12);
            this.cbbMerchandiseName.Name = "cbbMerchandiseName";
            this.cbbMerchandiseName.Size = new System.Drawing.Size(370, 26);
            this.cbbMerchandiseName.TabIndex = 9;
            this.cbbMerchandiseName.ValueMember = "MerchandiseId";
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsProduct;
            this.gridControl1.Location = new System.Drawing.Point(12, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(954, 424);
            this.gridControl1.TabIndex = 8;
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
            this.colMerchandiseName,
            this.colProductionTeam,
            this.colFinishTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMerchandiseName
            // 
            this.colMerchandiseName.FieldName = "MerchandiseName";
            this.colMerchandiseName.MinWidth = 25;
            this.colMerchandiseName.Name = "colMerchandiseName";
            this.colMerchandiseName.Visible = true;
            this.colMerchandiseName.VisibleIndex = 0;
            this.colMerchandiseName.Width = 94;
            // 
            // colProductionTeam
            // 
            this.colProductionTeam.FieldName = "ProductionTeam";
            this.colProductionTeam.MinWidth = 25;
            this.colProductionTeam.Name = "colProductionTeam";
            this.colProductionTeam.Visible = true;
            this.colProductionTeam.VisibleIndex = 1;
            this.colProductionTeam.Width = 94;
            // 
            // colFinishTime
            // 
            this.colFinishTime.FieldName = "FinishTime";
            this.colFinishTime.MinWidth = 25;
            this.colFinishTime.Name = "colFinishTime";
            this.colFinishTime.Visible = true;
            this.colFinishTime.VisibleIndex = 2;
            this.colFinishTime.Width = 94;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 84);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 27);
            this.btnInsert.StyleController = this.layoutControl1;
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "등록(&I)";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = global::InspectionProcess.Properties.Resources.Search2;
            this.btnSearch.Location = new System.Drawing.Point(803, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 68);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(978, 551);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSearch;
            this.layoutControlItem3.Location = new System.Drawing.Point(791, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(167, 72);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(416, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(375, 72);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnInsert;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(161, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(161, 72);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(797, 31);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 103);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(958, 428);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbbMerchandiseName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(416, 30);
            this.layoutControlItem6.Text = "상품명";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbTeam;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(416, 42);
            this.layoutControlItem1.Text = "생산조";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 18);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 551);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddProductForm";
            this.Text = "생산관리";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ComboBox cbbTeam;
        private System.Windows.Forms.ComboBox cbbMerchandiseName;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.BindingSource bdsProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bdsTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colMerchandiseName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishTime;
    }
}