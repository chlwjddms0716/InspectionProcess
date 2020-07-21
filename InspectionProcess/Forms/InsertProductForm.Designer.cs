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
            this.txeFinishTime = new DevExpress.XtraEditors.TextEdit();
            this.cbbMerchandise = new System.Windows.Forms.ComboBox();
            this.bdsMerchandise = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbbProductionTeamId = new System.Windows.Forms.ComboBox();
            this.bdsProductionTeamId = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeFinishTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionTeamId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbProductionTeamId);
            this.layoutControl1.Controls.Add(this.cbbMerchandise);
            this.layoutControl1.Controls.Add(this.txeFinishTime);
            this.layoutControl1.Size = new System.Drawing.Size(481, 259);
            this.layoutControl1.Controls.SetChildIndex(this.txeFinishTime, 0);
            this.layoutControl1.Controls.SetChildIndex(this.cbbMerchandise, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnClose, 0);
            this.layoutControl1.Controls.SetChildIndex(this.btnInsert, 0);
            this.layoutControl1.Controls.SetChildIndex(this.cbbProductionTeamId, 0);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.Root.Size = new System.Drawing.Size(481, 259);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem1.Size = new System.Drawing.Size(461, 120);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 208);
            this.emptySpaceItem2.Size = new System.Drawing.Size(274, 31);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(286, 220);
            this.btnInsert.Size = new System.Drawing.Size(89, 27);
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            // txeFinishTime
            // 
            this.txeFinishTime.Location = new System.Drawing.Point(102, 42);
            this.txeFinishTime.Name = "txeFinishTime";
            this.txeFinishTime.Size = new System.Drawing.Size(367, 24);
            this.txeFinishTime.StyleController = this.layoutControl1;
            this.txeFinishTime.TabIndex = 7;
            // 
            // cbbMerchandise
            // 
            this.cbbMerchandise.DataSource = this.bdsMerchandise;
            this.cbbMerchandise.DisplayMember = "Name";
            this.cbbMerchandise.FormattingEnabled = true;
            this.cbbMerchandise.Location = new System.Drawing.Point(102, 12);
            this.cbbMerchandise.Name = "cbbMerchandise";
            this.cbbMerchandise.Size = new System.Drawing.Size(367, 26);
            this.cbbMerchandise.TabIndex = 5;
            this.cbbMerchandise.ValueMember = "MerchandiseId";
            // 
            // bdsMerchandise
            // 
            this.bdsMerchandise.DataSource = typeof(InspectionProcess.Data.Merchandise);
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
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txeFinishTime;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "차번호";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(461, 28);
            this.layoutControlItem5.Text = "생산완료시간";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(78, 18);
            // 
            // cbbProductionTeamId
            // 
            this.cbbProductionTeamId.DataSource = this.bdsProductionTeamId;
            this.cbbProductionTeamId.DisplayMember = "ProductionTeam";
            this.cbbProductionTeamId.FormattingEnabled = true;
            this.cbbProductionTeamId.Location = new System.Drawing.Point(102, 70);
            this.cbbProductionTeamId.Name = "cbbProductionTeamId";
            this.cbbProductionTeamId.Size = new System.Drawing.Size(367, 26);
            this.cbbProductionTeamId.TabIndex = 8;
            this.cbbProductionTeamId.ValueMember = "ProductionTeam";
            // 
            // bdsProductionTeamId
            // 
            this.bdsProductionTeamId.DataSource = typeof(InspectionProcess.Data.Product);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbProductionTeamId;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(461, 30);
            this.layoutControlItem4.Text = "생산조ID";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(78, 18);
            // 
            // InsertProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 259);
            this.Name = "InsertProductForm";
            this.Text = "InsertProductForm";
            this.Load += new System.EventHandler(this.InsertProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeFinishTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMerchandise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProductionTeamId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMerchandise;
        private DevExpress.XtraEditors.TextEdit txeFinishTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bdsMerchandise;
        private System.Windows.Forms.ComboBox cbbProductionTeamId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdsProductionTeamId;
    }
}