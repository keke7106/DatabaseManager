﻿namespace DatabaseManager.Controls
{
    partial class UC_DbConnectionProfile
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DbConnectionProfile));
            this.btnDeleteDbProfile = new System.Windows.Forms.Button();
            this.btnConfigDbProfile = new System.Windows.Forms.Button();
            this.btnAddDbProfile = new System.Windows.Forms.Button();
            this.cboDbProfile = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboDbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteDbProfile
            // 
            this.btnDeleteDbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDbProfile.BackColor = System.Drawing.Color.White;
            this.btnDeleteDbProfile.FlatAppearance.BorderSize = 0;
            this.btnDeleteDbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDbProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteDbProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDbProfile.Image")));
            this.btnDeleteDbProfile.Location = new System.Drawing.Point(580, 5);
            this.btnDeleteDbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDbProfile.Name = "btnDeleteDbProfile";
            this.btnDeleteDbProfile.Size = new System.Drawing.Size(19, 17);
            this.btnDeleteDbProfile.TabIndex = 40;
            this.btnDeleteDbProfile.UseVisualStyleBackColor = false;
            this.btnDeleteDbProfile.Visible = false;
            this.btnDeleteDbProfile.Click += new System.EventHandler(this.btnDeleteDbProfile_Click);
            // 
            // btnConfigDbProfile
            // 
            this.btnConfigDbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigDbProfile.BackColor = System.Drawing.Color.White;
            this.btnConfigDbProfile.FlatAppearance.BorderSize = 0;
            this.btnConfigDbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigDbProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigDbProfile.Image")));
            this.btnConfigDbProfile.Location = new System.Drawing.Point(554, 5);
            this.btnConfigDbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfigDbProfile.Name = "btnConfigDbProfile";
            this.btnConfigDbProfile.Size = new System.Drawing.Size(20, 17);
            this.btnConfigDbProfile.TabIndex = 39;
            this.btnConfigDbProfile.UseVisualStyleBackColor = false;
            this.btnConfigDbProfile.Visible = false;
            this.btnConfigDbProfile.Click += new System.EventHandler(this.btnConfigDbProfile_Click);
            // 
            // btnAddDbProfile
            // 
            this.btnAddDbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDbProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDbProfile.Image")));
            this.btnAddDbProfile.Location = new System.Drawing.Point(621, 1);
            this.btnAddDbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDbProfile.Name = "btnAddDbProfile";
            this.btnAddDbProfile.Size = new System.Drawing.Size(38, 26);
            this.btnAddDbProfile.TabIndex = 38;
            this.btnAddDbProfile.UseVisualStyleBackColor = true;
            this.btnAddDbProfile.Click += new System.EventHandler(this.btnAddDbProfile_Click);
            // 
            // cboDbProfile
            // 
            this.cboDbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDbProfile.BackColor = System.Drawing.SystemColors.Window;
            this.cboDbProfile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDbProfile.FormattingEnabled = true;
            this.cboDbProfile.Location = new System.Drawing.Point(197, 2);
            this.cboDbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.cboDbProfile.Name = "cboDbProfile";
            this.cboDbProfile.Size = new System.Drawing.Size(424, 24);
            this.cboDbProfile.TabIndex = 37;
            this.cboDbProfile.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboDbProfile_DrawItem);
            this.cboDbProfile.SelectedIndexChanged += new System.EventHandler(this.cboDbProfile_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 17);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Tile:";
            // 
            // cboDbType
            // 
            this.cboDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDbType.FormattingEnabled = true;
            this.cboDbType.Location = new System.Drawing.Point(72, 1);
            this.cboDbType.Margin = new System.Windows.Forms.Padding(4);
            this.cboDbType.Name = "cboDbType";
            this.cboDbType.Size = new System.Drawing.Size(115, 25);
            this.cboDbType.TabIndex = 35;
            this.cboDbType.SelectedIndexChanged += new System.EventHandler(this.cboDbType_SelectedIndexChanged);
            // 
            // UC_DbConnectionProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteDbProfile);
            this.Controls.Add(this.btnConfigDbProfile);
            this.Controls.Add(this.btnAddDbProfile);
            this.Controls.Add(this.cboDbProfile);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboDbType);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_DbConnectionProfile";
            this.Size = new System.Drawing.Size(659, 28);
            this.Load += new System.EventHandler(this.UC_DbConnectionProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteDbProfile;
        private System.Windows.Forms.Button btnConfigDbProfile;
        private System.Windows.Forms.Button btnAddDbProfile;
        private System.Windows.Forms.ComboBox cboDbProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboDbType;
    }
}
