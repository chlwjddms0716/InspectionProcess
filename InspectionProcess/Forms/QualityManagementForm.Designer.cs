namespace InspectionProcess.Forms
{
    partial class QualityManagementForm
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
            this.lkuProductId = new DevExpress.XtraEditors.LookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lkuInspectionID = new DevExpress.XtraEditors.LookUpEdit();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lkuInspectionTeamName = new DevExpress.XtraEditors.LookUpEdit();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.inspectionResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInspectionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNormalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefectiveNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblInspectionTeam = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuInspectionID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuInspectionTeamName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInspectionTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchButtonControl1);
            this.layoutControl1.Controls.Add(this.lkuProductId);
            this.layoutControl1.Controls.Add(this.lkuInspectionID);
            this.layoutControl1.Controls.Add(this.lkuInspectionTeamName);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(861, 247, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 540);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchButtonControl1
            // 
            this.searchButtonControl1.Location = new System.Drawing.Point(640, 12);
            this.searchButtonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButtonControl1.Name = "searchButtonControl1";
            this.searchButtonControl1.Size = new System.Drawing.Size(148, 80);
            this.searchButtonControl1.TabIndex = 31;
            this.searchButtonControl1.SearchButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.SearchButtonClickedEventArgs>(this.searchButtonControl1_SearchButtonClicked);
            this.searchButtonControl1.ResetButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.ResetButtonClickedEventArgs>(this.searchButtonControl1_ResetButtonClicked);
            // 
            // lkuProductId
            // 
            this.lkuProductId.Location = new System.Drawing.Point(85, 40);
            this.lkuProductId.Name = "lkuProductId";
            this.lkuProductId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuProductId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductId", "")});
            this.lkuProductId.Properties.DataSource = this.productBindingSource;
            this.lkuProductId.Properties.DisplayMember = "ProductId";
            this.lkuProductId.Properties.ValueMember = "ProductId";
            this.lkuProductId.Size = new System.Drawing.Size(551, 24);
            this.lkuProductId.StyleController = this.layoutControl1;
            this.lkuProductId.TabIndex = 30;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(InspectionProcess.Data.Product);
            // 
            // lkuInspectionID
            // 
            this.lkuInspectionID.Location = new System.Drawing.Point(85, 12);
            this.lkuInspectionID.Name = "lkuInspectionID";
            this.lkuInspectionID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuInspectionID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InspectionId", "")});
            this.lkuInspectionID.Properties.DataSource = this.inspectionBindingSource;
            this.lkuInspectionID.Properties.DisplayMember = "InspectionId";
            this.lkuInspectionID.Properties.ValueMember = "InspectionId";
            this.lkuInspectionID.Size = new System.Drawing.Size(551, 24);
            this.lkuInspectionID.StyleController = this.layoutControl1;
            this.lkuInspectionID.TabIndex = 29;
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataSource = typeof(InspectionProcess.Data.Inspection);
            // 
            // lkuInspectionTeamName
            // 
            this.lkuInspectionTeamName.Location = new System.Drawing.Point(85, 68);
            this.lkuInspectionTeamName.Name = "lkuInspectionTeamName";
            this.lkuInspectionTeamName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuInspectionTeamName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "")});
            this.lkuInspectionTeamName.Properties.DataSource = this.teamBindingSource;
            this.lkuInspectionTeamName.Properties.DisplayMember = "Name";
            this.lkuInspectionTeamName.Properties.ValueMember = "TeamId";
            this.lkuInspectionTeamName.Size = new System.Drawing.Size(551, 24);
            this.lkuInspectionTeamName.StyleController = this.layoutControl1;
            this.lkuInspectionTeamName.TabIndex = 26;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(InspectionProcess.Data.Team);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.inspectionResultBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 432);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // inspectionResultBindingSource
            // 
            this.inspectionResultBindingSource.DataSource = typeof(InspectionProcess.Data.InspectionResult);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInspectionId,
            this.colProductId,
            this.gridColumn2,
            this.colCount,
            this.colNormalNumber,
            this.colDefectiveNumber,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInspectionId
            // 
            this.colInspectionId.Caption = "검사ID";
            this.colInspectionId.FieldName = "InspectionId";
            this.colInspectionId.MinWidth = 25;
            this.colInspectionId.Name = "colInspectionId";
            this.colInspectionId.Visible = true;
            this.colInspectionId.VisibleIndex = 0;
            this.colInspectionId.Width = 94;
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "상품명";
            this.gridColumn2.FieldName = "MerchandiseName";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // colCount
            // 
            this.colCount.Caption = "검사횟수";
            this.colCount.FieldName = "Count";
            this.colCount.MinWidth = 25;
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 3;
            this.colCount.Width = 94;
            // 
            // colNormalNumber
            // 
            this.colNormalNumber.Caption = "양품개수";
            this.colNormalNumber.FieldName = "NormalNumber";
            this.colNormalNumber.MinWidth = 25;
            this.colNormalNumber.Name = "colNormalNumber";
            this.colNormalNumber.Visible = true;
            this.colNormalNumber.VisibleIndex = 4;
            this.colNormalNumber.Width = 94;
            // 
            // colDefectiveNumber
            // 
            this.colDefectiveNumber.Caption = "불량품개수";
            this.colDefectiveNumber.FieldName = "DefectiveNumber";
            this.colDefectiveNumber.MinWidth = 25;
            this.colDefectiveNumber.Name = "colDefectiveNumber";
            this.colDefectiveNumber.Visible = true;
            this.colDefectiveNumber.VisibleIndex = 5;
            this.colDefectiveNumber.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "검사조";
            this.gridColumn1.FieldName = "InspectionTeamName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lblInspectionTeam,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 436);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lblInspectionTeam
            // 
            this.lblInspectionTeam.Control = this.lkuInspectionTeamName;
            this.lblInspectionTeam.Location = new System.Drawing.Point(0, 56);
            this.lblInspectionTeam.Name = "lblInspectionTeam";
            this.lblInspectionTeam.Size = new System.Drawing.Size(628, 28);
            this.lblInspectionTeam.Text = "검사조 : ";
            this.lblInspectionTeam.TextSize = new System.Drawing.Size(70, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lkuInspectionID;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(628, 28);
            this.layoutControlItem6.Text = "검사ID :";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lkuProductId;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(628, 28);
            this.layoutControlItem7.Text = "생산품ID : ";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(70, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.searchButtonControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(628, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(152, 84);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // QualityManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QualityManagementForm";
            this.Text = "품질관리";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkuProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuInspectionID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuInspectionTeamName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInspectionTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectionId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colNormalNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDefectiveNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LookUpEdit lkuInspectionTeamName;
        private DevExpress.XtraLayout.LayoutControlItem lblInspectionTeam;
        private DevExpress.XtraEditors.LookUpEdit lkuProductId;
        private DevExpress.XtraEditors.LookUpEdit lkuInspectionID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource inspectionResultBindingSource;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private UserControls.SearchButtonControl searchButtonControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}