namespace InspectionProcess.Forms
{
    partial class InsertProductForm
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
            this.teFinishTime = new DevExpress.XtraEditors.TimeEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dteFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueMerchandise = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueProductionTeamId = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.bdsProductionTeamId = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFinishTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMerchandise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductionTeamId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionTeamId)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueProductionTeamId);
            this.layoutControl1.Controls.Add(this.lueMerchandise);
            this.layoutControl1.Controls.Add(this.dteFinishDate);
            this.layoutControl1.Controls.Add(this.teFinishTime);
            this.layoutControl1.Size = new System.Drawing.Size(481, 259);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnAction, 0);
            this.layoutControl1.Controls.SetChildIndex(this.teFinishTime, 0);
            this.layoutControl1.Controls.SetChildIndex(this.dteFinishDate, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lueMerchandise, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lueProductionTeamId, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.Root.Size = new System.Drawing.Size(481, 259);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem1.Size = new System.Drawing.Size(461, 96);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 208);
            this.emptySpaceItem2.Size = new System.Drawing.Size(274, 31);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(286, 220);
            this.btnAction.Size = new System.Drawing.Size(89, 27);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(379, 220);
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(367, 208);
            this.layoutControlItem2.Size = new System.Drawing.Size(94, 31);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(274, 208);
            this.layoutControlItem3.Size = new System.Drawing.Size(93, 31);
            // 
            // teFinishTime
            // 
            this.teFinishTime.EditValue = new System.DateTime(2020, 7, 22, 0, 0, 0, 0);
            this.teFinishTime.Location = new System.Drawing.Point(94, 68);
            this.teFinishTime.Name = "teFinishTime";
            this.teFinishTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFinishTime.Size = new System.Drawing.Size(375, 24);
            this.teFinishTime.StyleController = this.layoutControl1;
            this.teFinishTime.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.teFinishTime;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem6.Text = "생산완료시각";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(78, 18);
            // 
            // dteFinishDate
            // 
            this.dteFinishDate.EditValue = null;
            this.dteFinishDate.Location = new System.Drawing.Point(94, 40);
            this.dteFinishDate.Name = "dteFinishDate";
            this.dteFinishDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Size = new System.Drawing.Size(375, 24);
            this.dteFinishDate.StyleController = this.layoutControl1;
            this.dteFinishDate.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dteFinishDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem7.Text = "생산완료일";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(78, 18);
            // 
            // lueMerchandise
            // 
            this.lueMerchandise.Location = new System.Drawing.Point(94, 12);
            this.lueMerchandise.Name = "lueMerchandise";
            this.lueMerchandise.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMerchandise.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueMerchandise.Properties.DataSource = this.bdsMerchandise;
            this.lueMerchandise.Properties.DisplayMember = "Name";
            this.lueMerchandise.Properties.NullText = "";
            this.lueMerchandise.Properties.ValueMember = "MerchandiseId";
            this.lueMerchandise.Size = new System.Drawing.Size(375, 24);
            this.lueMerchandise.StyleController = this.layoutControl1;
            this.lueMerchandise.TabIndex = 11;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueMerchandise;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem5.Text = "상품명";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(78, 18);
            // 
            // lueProductionTeamId
            // 
            this.lueProductionTeamId.Location = new System.Drawing.Point(94, 96);
            this.lueProductionTeamId.Name = "lueProductionTeamId";
            this.lueProductionTeamId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductionTeamId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "")});
            this.lueProductionTeamId.Properties.DataSource = this.bdsTeam;
            this.lueProductionTeamId.Properties.DisplayMember = "Name";
            this.lueProductionTeamId.Properties.NullText = "";
            this.lueProductionTeamId.Properties.ValueMember = "TeamId";
            this.lueProductionTeamId.Size = new System.Drawing.Size(375, 24);
            this.lueProductionTeamId.StyleController = this.layoutControl1;
            this.lueProductionTeamId.TabIndex = 12;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueProductionTeamId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem1.Text = "생산조";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(78, 18);
            // 
            // bdsTeam
            // 
            this.bdsTeam.DataSource = typeof(InspectionProcess.Data.Team);
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
            // 
            // bdsProductionTeamId
            // 
            this.bdsProductionTeamId.DataSource = typeof(InspectionProcess.Data.Product);
            // 
            // InsertProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 259);
            this.Name = "InsertProductForm";
            this.Text = "생산등록";
            this.Load += new System.EventHandler(this.InsertProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFinishTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMerchandise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductionTeamId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionTeamId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.BindingSource bdsProductionTeamId;
        private System.Windows.Forms.BindingSource bdsTeam;
        private DevExpress.XtraEditors.DateEdit dteFinishDate;
        private DevExpress.XtraEditors.TimeEdit teFinishTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit lueProductionTeamId;
        private DevExpress.XtraEditors.LookUpEdit lueMerchandise;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}