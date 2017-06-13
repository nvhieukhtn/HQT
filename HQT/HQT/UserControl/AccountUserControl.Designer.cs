namespace HQT
{
    partial class AccountUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(18, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(149, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(173, 6);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(134, 20);
            this.txtFullname.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::HQT.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(496, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(22, 22);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbRole
            // 
            this.cbRole.Enabled = false;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(313, 6);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 21);
            this.cbRole.TabIndex = 2;
            // 
            // btnDetail
            // 
            this.btnDetail.BackgroundImage = global::HQT.Properties.Resources.info;
            this.btnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Location = new System.Drawing.Point(471, 6);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(22, 22);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // AccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtUsername);
            this.Name = "AccountUserControl";
            this.Size = new System.Drawing.Size(539, 32);
            this.Load += new System.EventHandler(this.AccountUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnDetail;
    }
}
