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
            this.cbbMerchandise = new System.Windows.Forms.ComboBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbbProductionTeamId = new System.Windows.Forms.ComboBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teFinishTime = new DevExpress.XtraEditors.TimeEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dteFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFinishTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionTeamId)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dteFinishDate);
            this.layoutControl1.Controls.Add(this.teFinishTime);
            this.layoutControl1.Controls.Add(this.cbbProductionTeamId);
            this.layoutControl1.Controls.Add(this.cbbMerchandise);
            this.layoutControl1.Size = new System.Drawing.Size(481, 259);
            this.layoutControl1.Controls.SetChildIndex(this.cbbMerchandise, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnAction, 0);
            this.layoutControl1.Controls.SetChildIndex(this.cbbProductionTeamId, 0);
            this.layoutControl1.Controls.SetChildIndex(this.teFinishTime, 0);
            this.layoutControl1.Controls.SetChildIndex(this.dteFinishDate, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Size = new System.Drawing.Size(481, 259);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem1.Size = new System.Drawing.Size(461, 92);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 208);
            this.emptySpaceItem2.Size = new System.Drawing.Size(274, 31);
            // 
            // btnInsert
            // 
            this.btnAction.Location = new System.Drawing.Point(286, 220);
            this.btnAction.Size = new System.Drawing.Size(89, 27);
            this.btnAction.Click += new System.EventHandler(this.btnInsert_Click);
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
            // cbbMerchandise
            // 
            this.cbbMerchandise.DataSource = this.bdsMerchandise;
            this.cbbMerchandise.DisplayMember = "Name";
            this.cbbMerchandise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMerchandise.FormattingEnabled = true;
            this.cbbMerchandise.Location = new System.Drawing.Point(102, 12);
            this.cbbMerchandise.Name = "cbbMerchandise";
            this.cbbMerchandise.Size = new System.Drawing.Size(367, 26);
            this.cbbMerchandise.TabIndex = 5;
            this.cbbMerchandise.ValueMember = "MerchandiseId";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbMerchandise;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "지점Id";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(461, 30);
            this.layoutControlItem1.Text = "상품명";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(78, 18);
            // 
            // cbbProductionTeamId
            // 
            this.cbbProductionTeamId.DataSource = this.bdsTeam;
            this.cbbProductionTeamId.DisplayMember = "Name";
            this.cbbProductionTeamId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductionTeamId.FormattingEnabled = true;
            this.cbbProductionTeamId.Location = new System.Drawing.Point(102, 98);
            this.cbbProductionTeamId.Name = "cbbProductionTeamId";
            this.cbbProductionTeamId.Size = new System.Drawing.Size(367, 26);
            this.cbbProductionTeamId.TabIndex = 8;
            this.cbbProductionTeamId.ValueMember = "TeamId";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbProductionTeamId;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(461, 153);
            this.layoutControlItem4.Text = "생산조";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(78, 18);
            // 
            // teFinishTime
            // 
            this.teFinishTime.EditValue = new System.DateTime(2020, 7, 22, 0, 0, 0, 0);
            this.teFinishTime.Location = new System.Drawing.Point(102, 70);
            this.teFinishTime.Name = "teFinishTime";
            this.teFinishTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teFinishTime.Size = new System.Drawing.Size(367, 24);
            this.teFinishTime.StyleController = this.layoutControl1;
            this.teFinishTime.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.teFinishTime;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem6.Text = "생산완료시각";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(78, 18);
            // 
            // dteFinishDate
            // 
            this.dteFinishDate.EditValue = null;
            this.dteFinishDate.Location = new System.Drawing.Point(102, 42);
            this.dteFinishDate.Name = "dteFinishDate";
            this.dteFinishDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFinishDate.Size = new System.Drawing.Size(367, 24);
            this.dteFinishDate.StyleController = this.layoutControl1;
            this.dteFinishDate.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dteFinishDate;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem7.Text = "생산완료일";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(78, 18);
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFinishTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFinishDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionTeamId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMerchandise;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.ComboBox cbbProductionTeamId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdsProductionTeamId;
        private System.Windows.Forms.BindingSource bdsTeam;
        private DevExpress.XtraEditors.DateEdit dteFinishDate;
        private DevExpress.XtraEditors.TimeEdit teFinishTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}