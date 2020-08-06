namespace InspectionProcess.Forms
{
    partial class InsertInspectionForm
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
            this.lueTeamName = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsWarehouse = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueTeamName);
            this.layoutControl1.Size = new System.Drawing.Size(457, 247);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnAction, 0);
            this.layoutControl1.Controls.SetChildIndex(this.lueTeamName, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.Root.Size = new System.Drawing.Size(457, 247);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 168);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 196);
            this.emptySpaceItem2.Size = new System.Drawing.Size(256, 31);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(268, 208);
            this.btnAction.Size = new System.Drawing.Size(86, 27);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(358, 208);
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(346, 196);
            this.layoutControlItem2.Size = new System.Drawing.Size(91, 31);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(256, 196);
            this.layoutControlItem3.Size = new System.Drawing.Size(90, 31);
            // 
            // lueTeamName
            // 
            this.lueTeamName.Location = new System.Drawing.Point(55, 12);
            this.lueTeamName.Name = "lueTeamName";
            this.lueTeamName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTeamName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeamId", "Team Id", 69, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueTeamName.Properties.DataSource = this.bdsTeam;
            this.lueTeamName.Properties.DisplayMember = "Name";
            this.lueTeamName.Properties.NullText = "";
            this.lueTeamName.Properties.ValueMember = "TeamId";
            this.lueTeamName.Size = new System.Drawing.Size(390, 24);
            this.lueTeamName.StyleController = this.layoutControl1;
            this.lueTeamName.TabIndex = 7;
            // 
            // bdsTeam
            // 
            this.bdsTeam.DataSource = typeof(InspectionProcess.Data.Team);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lueTeamName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(437, 28);
            this.layoutControlItem4.Text = "검사조";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(39, 18);
            // 
            // bdsWarehouse
            // 
            this.bdsWarehouse.DataSource = typeof(InspectionProcess.Data.Warehouse);
            // 
            // InsertInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 247);
            this.Name = "InsertInspectionForm";
            this.Text = "작업지시";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsWarehouse;
        private System.Windows.Forms.BindingSource bdsTeam;
        private DevExpress.XtraEditors.LookUpEdit lueTeamName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}