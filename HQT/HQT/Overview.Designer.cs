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
            this.tabOverview = new System.Windows.Forms.TabControl();
            this.tabAvailableProject = new System.Windows.Forms.TabPage();
            this.overviewAvailableProjectTabContentUserControl1 = new HQT.OverviewAvailableProjectTabContentUserControl();
            this.tabExpireProject = new System.Windows.Forms.TabPage();
            this.overviewExpireProjectTabContentUserControl1 = new HQT.OverviewExpireProjectTabContentUserControl();
            this.tabAvailableTopic = new System.Windows.Forms.TabPage();
            this.overviewAvailableTopicTabContentUserControl1 = new HQT.OverviewAvailableTopicTabContentUserControl();
            this.tabSubject = new System.Windows.Forms.TabPage();
            this.overviewSubjectTabContentUserControl = new HQT.OverviewSubjectTabContentUserControl();
            this.tabOverview.SuspendLayout();
            this.tabAvailableProject.SuspendLayout();
            this.tabExpireProject.SuspendLayout();
            this.tabAvailableTopic.SuspendLayout();
            this.tabSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tabSubject);
            this.tabOverview.Controls.Add(this.tabAvailableProject);
            this.tabOverview.Controls.Add(this.tabExpireProject);
            this.tabOverview.Controls.Add(this.tabAvailableTopic);
            this.tabOverview.Location = new System.Drawing.Point(17, 67);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedIndex = 0;
            this.tabOverview.Size = new System.Drawing.Size(655, 332);
            this.tabOverview.TabIndex = 1;
            // 
            // tabAvailableProject
            // 
            this.tabAvailableProject.Controls.Add(this.overviewAvailableProjectTabContentUserControl1);
            this.tabAvailableProject.Location = new System.Drawing.Point(4, 22);
            this.tabAvailableProject.Name = "tabAvailableProject";
            this.tabAvailableProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailableProject.Size = new System.Drawing.Size(647, 306);
            this.tabAvailableProject.TabIndex = 0;
            this.tabAvailableProject.Text = "Đồ án đang có";
            this.tabAvailableProject.UseVisualStyleBackColor = true;
            // 
            // overviewAvailableProjectTabContentUserControl1
            // 
            this.overviewAvailableProjectTabContentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.overviewAvailableProjectTabContentUserControl1.Name = "overviewAvailableProjectTabContentUserControl1";
            this.overviewAvailableProjectTabContentUserControl1.Size = new System.Drawing.Size(647, 306);
            this.overviewAvailableProjectTabContentUserControl1.TabIndex = 0;
            // 
            // tabExpireProject
            // 
            this.tabExpireProject.Controls.Add(this.overviewExpireProjectTabContentUserControl1);
            this.tabExpireProject.Location = new System.Drawing.Point(4, 22);
            this.tabExpireProject.Name = "tabExpireProject";
            this.tabExpireProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpireProject.Size = new System.Drawing.Size(647, 306);
            this.tabExpireProject.TabIndex = 1;
            this.tabExpireProject.Text = "Đồ án đã hết hạn";
            this.tabExpireProject.UseVisualStyleBackColor = true;
            // 
            // overviewExpireProjectTabContentUserControl1
            // 
            this.overviewExpireProjectTabContentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.overviewExpireProjectTabContentUserControl1.Name = "overviewExpireProjectTabContentUserControl1";
            this.overviewExpireProjectTabContentUserControl1.Size = new System.Drawing.Size(647, 306);
            this.overviewExpireProjectTabContentUserControl1.TabIndex = 0;
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
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tabOverview);
            this.Name = "Overview";
            this.Text = "Tổng quan";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.tabOverview, 0);
            this.tabOverview.ResumeLayout(false);
            this.tabAvailableProject.ResumeLayout(false);
            this.tabExpireProject.ResumeLayout(false);
            this.tabAvailableTopic.ResumeLayout(false);
            this.tabSubject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOverview;
        private System.Windows.Forms.TabPage tabAvailableProject;
        private System.Windows.Forms.TabPage tabExpireProject;
        private System.Windows.Forms.TabPage tabAvailableTopic;
        private System.Windows.Forms.TabPage tabSubject;
        private OverviewAvailableProjectTabContentUserControl overviewAvailableProjectTabContentUserControl1;
        private OverviewExpireProjectTabContentUserControl overviewExpireProjectTabContentUserControl1;
        private OverviewAvailableTopicTabContentUserControl overviewAvailableTopicTabContentUserControl1;
        private OverviewSubjectTabContentUserControl overviewSubjectTabContentUserControl;
    }
}