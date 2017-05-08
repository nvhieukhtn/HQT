namespace HQT
{
    partial class AccountManagerForm
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackgroundImage = global::HQT.Properties.Resources.add_member;
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(619, 60);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(30, 30);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // AccountManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnAddAccount);
            this.Name = "AccountManagerForm";
            this.Text = "Quản lý tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountManagerForm_Load);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.btnAddAccount, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAccount;
    }
}