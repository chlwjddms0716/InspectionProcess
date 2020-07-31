﻿namespace InspectionProcess.Forms
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
            this.searchButtonControl1 = new InspectionProcess.UserControls.SearchButtonControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cbbTeam = new System.Windows.Forms.ComboBox();
            this.bdsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMerchandiseName = new System.Windows.Forms.ComboBox();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMerchandiseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchButtonControl1);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.cbbTeam);
            this.layoutControl1.Controls.Add(this.cbbMerchandiseName);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnInsert);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(796, 551);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchButtonControl1
            // 
            this.searchButtonControl1.Location = new System.Drawing.Point(653, 12);
            this.searchButtonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButtonControl1.Name = "searchButtonControl1";
            this.searchButtonControl1.Size = new System.Drawing.Size(131, 87);
            this.searchButtonControl1.TabIndex = 13;
            this.searchButtonControl1.SearchButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.SearchButtonClickedEventArgs>(this.searchButtonControl1_SearchButtonClicked);
            this.searchButtonControl1.ResetButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.ResetButtonClickedEventArgs>(this.searchButtonControl1_ResetButtonClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "삭제(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbbTeam
            // 
            this.cbbTeam.DataSource = this.bdsTeam;
            this.cbbTeam.DisplayMember = "Name";
            this.cbbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTeam.FormattingEnabled = true;
            this.cbbTeam.Location = new System.Drawing.Point(54, 42);
            this.cbbTeam.Name = "cbbTeam";
            this.cbbTeam.Size = new System.Drawing.Size(595, 26);
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
            this.cbbMerchandiseName.Size = new System.Drawing.Size(595, 26);
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
            this.gridControl1.Location = new System.Drawing.Point(12, 103);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(772, 436);
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
            this.colProductId,
            this.colMerchandiseName,
            this.colProductionTeam,
            this.colFinishTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.MinWidth = 25;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            this.colProductId.Width = 212;
            // 
            // colMerchandiseName
            // 
            this.colMerchandiseName.FieldName = "MerchandiseName";
            this.colMerchandiseName.MinWidth = 25;
            this.colMerchandiseName.Name = "colMerchandiseName";
            this.colMerchandiseName.Visible = true;
            this.colMerchandiseName.VisibleIndex = 1;
            this.colMerchandiseName.Width = 237;
            // 
            // colProductionTeam
            // 
            this.colProductionTeam.FieldName = "ProductionTeam";
            this.colProductionTeam.MinWidth = 25;
            this.colProductionTeam.Name = "colProductionTeam";
            this.colProductionTeam.Visible = true;
            this.colProductionTeam.VisibleIndex = 2;
            this.colProductionTeam.Width = 237;
            // 
            // colFinishTime
            // 
            this.colFinishTime.FieldName = "FinishTime";
            this.colFinishTime.MinWidth = 25;
            this.colFinishTime.Name = "colFinishTime";
            this.colFinishTime.Visible = true;
            this.colFinishTime.VisibleIndex = 3;
            this.colFinishTime.Width = 238;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 72);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 27);
            this.btnInsert.StyleController = this.layoutControl1;
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "등록(&I)";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(796, 551);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnInsert;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(90, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(179, 60);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(462, 31);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(776, 440);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbbMerchandiseName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(641, 30);
            this.layoutControlItem6.Text = "상품명";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbTeam;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(641, 30);
            this.layoutControlItem1.Text = "생산조";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDelete;
            this.layoutControlItem7.Location = new System.Drawing.Point(90, 60);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(89, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.searchButtonControl1;
            this.layoutControlItem8.Location = new System.Drawing.Point(641, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(135, 91);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 551);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::InspectionProcess.Properties.Resources.KakaoTalk_20200722_115827447;
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
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
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private UserControls.SearchButtonControl searchButtonControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}