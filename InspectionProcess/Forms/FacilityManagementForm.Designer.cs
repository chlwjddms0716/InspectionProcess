namespace InspectionProcess.Forms
{
    partial class FacilityManagementForm
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
            this.uscSearch = new InspectionProcess.UserControls.SearchButtonControl();
            this.dteFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.dteStartDate = new DevExpress.XtraEditors.DateEdit();
            this.grcInspection = new DevExpress.XtraGrid.GridControl();
            this.bdsInspection = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.날짜 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.검사Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.가동시작시간 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.가동종료시간 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcInspection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.uscSearch);
            this.layoutControl1.Controls.Add(this.dteFinishDate);
            this.layoutControl1.Controls.Add(this.dteStartDate);
            this.layoutControl1.Controls.Add(this.grcInspection);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(707, 353, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(886, 613);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // uscSearch
            // 
            this.uscSearch.Location = new System.Drawing.Point(739, 12);
            this.uscSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(135, 76);
            this.uscSearch.TabIndex = 13;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.SearchButtonClickedEventArgs>(this.uscSearch_SearchButtonClicked);
            this.uscSearch.ResetButtonClicked += new System.EventHandler<InspectionProcess.UserControls.SearchButtonControl.ResetButtonClickedEventArgs>(this.uscSearch_ResetButtonClicked);
            // 
            // dteFinishDate
            // 
            this.dteFinishDate.EditValue = null;
            this.dteFinishDate.Location = new System.Drawing.Point(411, 23);
            this.dteFinishDate.Name = "dteFinishDate";
            this.dteFinishDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Size = new System.Drawing.Size(324, 24);
            this.dteFinishDate.StyleController = this.layoutControl1;
            this.dteFinishDate.TabIndex = 6;
            // 
            // dteStartDate
            // 
            this.dteStartDate.EditValue = null;
            this.dteStartDate.Location = new System.Drawing.Point(46, 23);
            this.dteStartDate.Name = "dteStartDate";
            this.dteStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDate.Size = new System.Drawing.Size(327, 24);
            this.dteStartDate.StyleController = this.layoutControl1;
            this.dteStartDate.TabIndex = 5;
            // 
            // grcInspection
            // 
            this.grcInspection.DataSource = this.bdsInspection;
            this.grcInspection.Location = new System.Drawing.Point(12, 92);
            this.grcInspection.MainView = this.gridView1;
            this.grcInspection.Name = "grcInspection";
            this.grcInspection.Size = new System.Drawing.Size(862, 509);
            this.grcInspection.TabIndex = 4;
            this.grcInspection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsInspection
            // 
            this.bdsInspection.DataSource = typeof(InspectionProcess.Data.Inspection);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.날짜,
            this.검사Id,
            this.가동시작시간,
            this.가동종료시간});
            this.gridView1.GridControl = this.grcInspection;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // 날짜
            // 
            this.날짜.Caption = "날짜";
            this.날짜.DisplayFormat.FormatString = "d";
            this.날짜.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.날짜.FieldName = "StartTime";
            this.날짜.MinWidth = 25;
            this.날짜.Name = "날짜";
            this.날짜.Visible = true;
            this.날짜.VisibleIndex = 0;
            this.날짜.Width = 94;
            // 
            // 검사Id
            // 
            this.검사Id.Caption = "검사Id";
            this.검사Id.FieldName = "InspectionId";
            this.검사Id.MinWidth = 25;
            this.검사Id.Name = "검사Id";
            this.검사Id.Visible = true;
            this.검사Id.VisibleIndex = 1;
            this.검사Id.Width = 94;
            // 
            // 가동시작시간
            // 
            this.가동시작시간.Caption = "가동시작시간";
            this.가동시작시간.DisplayFormat.FormatString = "hh:mm:ss";
            this.가동시작시간.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.가동시작시간.FieldName = "StartTime";
            this.가동시작시간.MinWidth = 25;
            this.가동시작시간.Name = "가동시작시간";
            this.가동시작시간.OptionsColumn.ReadOnly = true;
            this.가동시작시간.Visible = true;
            this.가동시작시간.VisibleIndex = 2;
            this.가동시작시간.Width = 94;
            // 
            // 가동종료시간
            // 
            this.가동종료시간.Caption = "가동종료시간";
            this.가동종료시간.DisplayFormat.FormatString = "hh:mm:ss";
            this.가동종료시간.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.가동종료시간.FieldName = "FinishTime";
            this.가동종료시간.MinWidth = 25;
            this.가동종료시간.Name = "가동종료시간";
            this.가동종료시간.Visible = true;
            this.가동종료시간.VisibleIndex = 3;
            this.가동종료시간.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(886, 613);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcInspection;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(866, 513);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dteStartDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 11);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(365, 28);
            this.layoutControlItem2.Text = "날짜 ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(31, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dteFinishDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(365, 11);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(362, 28);
            this.layoutControlItem3.Text = " ~";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(31, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 39);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(727, 41);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(727, 11);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.uscSearch;
            this.layoutControlItem6.Location = new System.Drawing.Point(727, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(139, 80);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FacilityManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 613);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FacilityManagementForm";
            this.Text = "설비관리";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcInspection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grcInspection;
        private System.Windows.Forms.BindingSource bdsInspection;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn 검사Id;
        private DevExpress.XtraGrid.Columns.GridColumn 가동시작시간;
        private DevExpress.XtraGrid.Columns.GridColumn 가동종료시간;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn 날짜;
        private DevExpress.XtraEditors.DateEdit dteFinishDate;
        private DevExpress.XtraEditors.DateEdit dteStartDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private UserControls.SearchButtonControl uscSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}