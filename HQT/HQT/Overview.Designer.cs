namespace HQT
{
    partial class Overview
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
            this.tabAvailableTopic = new System.Windows.Forms.TabPage();
            this.overviewAvailableTopicTabContentUserControl1 = new HQT.OverviewAvailableTopicTabContentUserControl();
            this.tabSubject = new System.Windows.Forms.TabPage();
            this.overviewSubjectTabContentUserControl = new HQT.OverviewSubjectTabContentUserControl();
            this.tabOverview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.overviewPracetice = new HQT.OverviewAvailableProjectTabContentUserControl();
            this.tabAvailableTopic.SuspendLayout();
            this.tabSubject.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAvailableTopic
            // 
            this.tabAvailableTopic.Controls.Add(this.overviewAvailableTopicTabContentUserControl1);
            this.tabAvailableTopic.Location = new System.Drawing.Point(4, 22);
            this.tabAvailableTopic.Name = "tabAvailableTopic";
            this.tabAvailableTopic.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailableTopic.Size = new System.Drawing.Size(647, 306);
            this.tabAvailableTopic.TabIndex = 2;
            this.tabAvailableTopic.Text = "Danh sách đề tài";
            this.tabAvailableTopic.UseVisualStyleBackColor = true;
            // 
            // overviewAvailableTopicTabContentUserControl1
            // 
            this.overviewAvailableTopicTabContentUserControl1.ListTopics = null;
            this.overviewAvailableTopicTabContentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.overviewAvailableTopicTabContentUserControl1.Name = "overviewAvailableTopicTabContentUserControl1";
            this.overviewAvailableTopicTabContentUserControl1.Size = new System.Drawing.Size(647, 306);
            this.overviewAvailableTopicTabContentUserControl1.TabIndex = 0;
            // 
            // tabSubject
            // 
            this.tabSubject.Controls.Add(this.overviewSubjectTabContentUserControl);
            this.tabSubject.Location = new System.Drawing.Point(4, 22);
            this.tabSubject.Name = "tabSubject";
            this.tabSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubject.Size = new System.Drawing.Size(647, 306);
            this.tabSubject.TabIndex = 4;
            this.tabSubject.Text = "Danh sách môn học";
            this.tabSubject.UseVisualStyleBackColor = true;
            // 
            // overviewSubjectTabContentUserControl
            // 
            this.overviewSubjectTabContentUserControl.Location = new System.Drawing.Point(0, 0);
            this.overviewSubjectTabContentUserControl.Name = "overviewSubjectTabContentUserControl";
            this.overviewSubjectTabContentUserControl.Size = new System.Drawing.Size(647, 306);
            this.overviewSubjectTabContentUserControl.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tabSubject);
            this.tabOverview.Controls.Add(this.tabPage1);
            this.tabOverview.Controls.Add(this.tabAvailableTopic);
            this.tabOverview.Location = new System.Drawing.Point(17, 67);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedIndex = 0;
            this.tabOverview.Size = new System.Drawing.Size(655, 332);
            this.tabOverview.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.overviewPracetice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 306);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Bài tập cộng điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // overviewPracetice
            // 
            this.overviewPracetice.ListProjects = null;
            this.overviewPracetice.Location = new System.Drawing.Point(0, 0);
            this.overviewPracetice.Name = "overviewPracetice";
            this.overviewPracetice.Size = new System.Drawing.Size(647, 306);
            this.overviewPracetice.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tabOverview);
            this.Name = "Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng quan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overview_FormClosing);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.Controls.SetChildIndex(this.tabOverview, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.tabAvailableTopic.ResumeLayout(false);
            this.tabSubject.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAvailableTopic;
        private OverviewAvailableTopicTabContentUserControl overviewAvailableTopicTabContentUserControl1;
        private System.Windows.Forms.TabPage tabSubject;
        private OverviewSubjectTabContentUserControl overviewSubjectTabContentUserControl;
        private System.Windows.Forms.TabControl tabOverview;
        private System.Windows.Forms.TabPage tabPage1;
        private OverviewAvailableProjectTabContentUserControl overviewPracetice;
    }
}