namespace InspectionProcess.Forms.UpdateForms
{
    partial class UpdateProductForm
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
            this.txeProductId = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.bdsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.dteFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teFinishTime = new DevExpress.XtraEditors.TimeEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueMerchandiseName = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueTeamName = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFinishTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMerchandiseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueTeamName);
            this.layoutControl1.Controls.Add(this.lueMerchandiseName);
            this.layoutControl1.Controls.Add(this.teFinishTime);
            this.layoutControl1.Controls.Add(this.dteFinishDate);
            this.layoutControl1.Controls.Add(this.txeProductId);
            this.layoutControl1.Size = new System.Drawing.Size(507, 306);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnAction, 0);
            this.layoutControl1.Controls.SetChildIndex(this.txeProductId, 0);
            this.layoutControl1.Controls.SetChildIndex(this.dteFinishDate, 0);
            this.layoutControl1.Controls.SetChildIndex(this.teFinishTime, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lueMerchandiseName, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lueTeamName, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem4});
            this.Root.Size = new System.Drawing.Size(507, 306);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 140);
            this.emptySpaceItem1.Size = new System.Drawing.Size(487, 115);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 255);
            this.emptySpaceItem2.Size = new System.Drawing.Size(285, 31);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(297, 267);
            this.btnAction.Size = new System.Drawing.Size(97, 27);
            this.btnAction.Text = "수정(&U)";
            //this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(398, 267);
            this.btnClose.Size = new System.Drawing.Size(97, 27);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(386, 255);
            this.layoutControlItem2.Size = new System.Drawing.Size(101, 31);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(285, 255);
            this.layoutControlItem3.Size = new System.Drawing.Size(101, 31);
            // 
            // txeProductId
            // 
            this.txeProductId.Enabled = false;
            this.txeProductId.Location = new System.Drawing.Point(102, 12);
            this.txeProductId.Name = "txeProductId";
            this.txeProductId.Size = new System.Drawing.Size(393, 24);
            this.txeProductId.StyleController = this.layoutControl1;
            this.txeProductId.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeProductId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem1.Text = "생산ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(78, 18);
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
            // 
            // bdsTeam
            // 
            this.bdsTeam.DataSource = typeof(InspectionProcess.Data.Team);
            // 
            // dteFinishDate
            // 
            this.dteFinishDate.EditValue = null;
            this.dteFinishDate.Location = new System.Drawing.Point(102, 96);
            this.dteFinishDate.Name = "dteFinishDate";
            this.dteFinishDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Size = new System.Drawing.Size(393, 24);
            this.dteFinishDate.StyleController = this.layoutControl1;
            this.dteFinishDate.TabIndex = 10;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dteFinishDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem6.Text = "생산완료일";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(78, 18);
            // 
            // teFinishTime
            // 
            this.teFinishTime.EditValue = new System.DateTime(2020, 7, 22, 0, 0, 0, 0);
            this.teFinishTime.Location = new System.Drawing.Point(102, 124);
            this.teFinishTime.Name = "teFinishTime";
            this.teFinishTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFinishTime.Size = new System.Drawing.Size(393, 24);
            this.teFinishTime.StyleController = this.layoutControl1;
            this.teFinishTime.TabIndex = 11;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.teFinishTime;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem7.Text = "생산완료시간";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(78, 18);
            // 
            // lueMerchandiseName
            // 
            this.lueMerchandiseName.Location = new System.Drawing.Point(102, 40);
            this.lueMerchandiseName.Name = "lueMerchandiseName";
            this.lueMerchandiseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMerchandiseName.Properties.DataSource = this.bdsMerchandise;
            this.lueMerchandiseName.Properties.DisplayMember = "Name";
            this.lueMerchandiseName.Properties.ValueMember = "MerchandiseId";
            this.lueMerchandiseName.Size = new System.Drawing.Size(393, 24);
            this.lueMerchandiseName.StyleController = this.layoutControl1;
            this.lueMerchandiseName.TabIndex = 12;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lueMerchandiseName;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem8.Text = "상품명";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(78, 18);
            // 
            // lueTeamName
            // 
            this.lueTeamName.Location = new System.Drawing.Point(102, 68);
            this.lueTeamName.Name = "lueTeamName";
            this.lueTeamName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTeamName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeamId", "Team Id", 69, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTeamName.Properties.DataSource = this.bdsTeam;
            this.lueTeamName.Properties.DisplayMember = "Name";
            this.lueTeamName.Properties.ValueMember = "TeamId";
            this.lueTeamName.Size = new System.Drawing.Size(393, 24);
            this.lueTeamName.StyleController = this.layoutControl1;
            this.lueTeamName.TabIndex = 13;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lueTeamName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(487, 28);
            this.layoutControlItem4.Text = "생산조";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(78, 18);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 306);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFinishTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMerchandiseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txeProductId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TimeEdit teFinishTime;
        private DevExpress.XtraEditors.DateEdit dteFinishDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.BindingSource bdsTeam;
        private DevExpress.XtraEditors.LookUpEdit lueTeamName;
        private DevExpress.XtraEditors.LookUpEdit lueMerchandiseName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}