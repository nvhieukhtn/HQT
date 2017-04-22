namespace HQT
{
    partial class Home
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
            this.funcAccount = new HQT.Function();
            this.funcSubject = new HQT.Function();
            this.funcHistory = new HQT.Function();
            this.funcLogout = new HQT.Function();
            this.SuspendLayout();
            // 
            // funcAccount
            // 
            this.funcAccount.Location = new System.Drawing.Point(30, 30);
            this.funcAccount.Name = "funcAccount";
            this.funcAccount.Size = new System.Drawing.Size(100, 100);
            this.funcAccount.TabIndex = 0;
            // 
            // funcSubject
            // 
            this.funcSubject.Location = new System.Drawing.Point(150, 30);
            this.funcSubject.Name = "funcSubject";
            this.funcSubject.Size = new System.Drawing.Size(100, 100);
            this.funcSubject.TabIndex = 0;
            // 
            // funcHistory
            // 
            this.funcHistory.Location = new System.Drawing.Point(270, 30);
            this.funcHistory.Name = "funcHistory";
            this.funcHistory.Size = new System.Drawing.Size(100, 100);
            this.funcHistory.TabIndex = 0;
            // 
            // funcLogout
            // 
            this.funcLogout.Location = new System.Drawing.Point(390, 30);
            this.funcLogout.Name = "funcLogout";
            this.funcLogout.Size = new System.Drawing.Size(100, 100);
            this.funcLogout.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.funcLogout);
            this.Controls.Add(this.funcHistory);
            this.Controls.Add(this.funcSubject);
            this.Controls.Add(this.funcAccount);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Function funcAccount;
        private Function funcSubject;
        private Function funcHistory;
        private Function funcLogout;
    }
}