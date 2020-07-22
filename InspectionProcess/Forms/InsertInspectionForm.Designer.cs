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
            this.cbbTeamName = new System.Windows.Forms.ComboBox();
            this.bdsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.bdsWarehouse = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbTeamName);
            this.layoutControl1.Size = new System.Drawing.Size(552, 247);
            this.layoutControl1.Controls.SetChildIndex(this.cbbTeamName, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnAction, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Size = new System.Drawing.Size(552, 247);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 30);
            this.emptySpaceItem1.Size = new System.Drawing.Size(532, 166);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 196);
            this.emptySpaceItem2.Size = new System.Drawing.Size(312, 31);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(324, 208);
            this.btnAction.Size = new System.Drawing.Size(105, 27);
            this.btnAction.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 208);
            this.btnClose.Size = new System.Drawing.Size(107, 27);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(421, 196);
            this.layoutControlItem2.Size = new System.Drawing.Size(111, 31);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(312, 196);
            this.layoutControlItem3.Size = new System.Drawing.Size(109, 31);
            // 
            // cbbTeamName
            // 
            this.cbbTeamName.DataSource = this.bdsTeam;
            this.cbbTeamName.DisplayMember = "Name";
            this.cbbTeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTeamName.FormattingEnabled = true;
            this.cbbTeamName.Location = new System.Drawing.Point(63, 12);
            this.cbbTeamName.Name = "cbbTeamName";
            this.cbbTeamName.Size = new System.Drawing.Size(477, 26);
            this.cbbTeamName.TabIndex = 5;
            this.cbbTeamName.ValueMember = "TeamId";
            // 
            // bdsTeam
            // 
            this.bdsTeam.DataSource = typeof(InspectionProcess.Data.Team);
            // 
            // bdsWarehouse
            // 
            this.bdsWarehouse.DataSource = typeof(InspectionProcess.Data.Warehouse);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbTeamName;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "검사조ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(532, 30);
            this.layoutControlItem1.Text = "검사조";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 18);
            // 
            // InsertInspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 247);
            this.Name = "InsertInspectionForm";
            this.Text = "작업지시";
            this.Load += new System.EventHandler(this.InsertInspectionForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTeamName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bdsWarehouse;
        private System.Windows.Forms.BindingSource bdsTeam;
    }
}