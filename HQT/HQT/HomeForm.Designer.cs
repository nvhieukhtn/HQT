namespace HQT
{
    partial class HomeForm
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
            this.funcAccount = new HQT.FunctionUserControl();
            this.funcSubject = new HQT.FunctionUserControl();
            this.funcHistory = new HQT.FunctionUserControl();
            this.funcLogout = new HQT.FunctionUserControl();
            this.funcStatistics = new HQT.FunctionUserControl();
            this.SuspendLayout();
            // 
            // funcAccount
            // 
            this.funcAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.funcAccount.Location = new System.Drawing.Point(30, 30);
            this.funcAccount.Name = "funcAccount";
            this.funcAccount.Size = new System.Drawing.Size(100, 100);
            this.funcAccount.TabIndex = 0;
            this.funcAccount.FunctionClicked += new HQT.FunctionUserControl.FunctionClickedEventHandler(this.funcAccount_FunctionClicked);
            // 
            // funcSubject
            // 
            this.funcSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.funcSubject.Location = new System.Drawing.Point(150, 30);
            this.funcSubject.Name = "funcSubject";
            this.funcSubject.Size = new System.Drawing.Size(100, 100);
            this.funcSubject.TabIndex = 0;
            this.funcSubject.FunctionClicked += new HQT.FunctionUserControl.FunctionClickedEventHandler(this.funcSubject_FunctionClicked);
            // 
            // funcHistory
            // 
            this.funcHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.funcHistory.Location = new System.Drawing.Point(270, 30);
            this.funcHistory.Name = "funcHistory";
            this.funcHistory.Size = new System.Drawing.Size(100, 100);
            this.funcHistory.TabIndex = 0;
            this.funcHistory.FunctionClicked += new HQT.FunctionUserControl.FunctionClickedEventHandler(this.funcHistory_FunctionClicked);
            // 
            // funcLogout
            // 
            this.funcLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.funcLogout.Location = new System.Drawing.Point(508, 30);
            this.funcLogout.Name = "funcLogout";
            this.funcLogout.Size = new System.Drawing.Size(100, 100);
            this.funcLogout.TabIndex = 0;
            this.funcLogout.FunctionClicked += new HQT.FunctionUserControl.FunctionClickedEventHandler(this.funcLogout_FunctionClicked);
            // 
            // funcStatistics
            // 
            this.funcStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.funcStatistics.Location = new System.Drawing.Point(389, 30);
            this.funcStatistics.Name = "funcStatistics";
            this.funcStatistics.Size = new System.Drawing.Size(100, 100);
            this.funcStatistics.TabIndex = 0;
            this.funcStatistics.FunctionClicked += new HQT.FunctionUserControl.FunctionClickedEventHandler(this.funcStatistics_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.funcStatistics);
            this.Controls.Add(this.funcLogout);
            this.Controls.Add(this.funcHistory);
            this.Controls.Add(this.funcSubject);
            this.Controls.Add(this.funcAccount);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private FunctionUserControl funcAccount;
        private FunctionUserControl funcSubject;
        private FunctionUserControl funcHistory;
        private FunctionUserControl funcLogout;
        private FunctionUserControl funcStatistics;
    }
}