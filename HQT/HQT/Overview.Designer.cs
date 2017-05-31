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
            this.tabAvailableProject = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabExpireProject = new System.Windows.Forms.TabPage();
            this.tabAvailableTopic = new System.Windows.Forms.TabPage();
            this.tabExpireTopic = new System.Windows.Forms.TabPage();
            this.tabSubject = new System.Windows.Forms.TabPage();
            this.tabAvailableProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAvailableProject
            // 
            this.tabAvailableProject.Controls.Add(this.tabPage1);
            this.tabAvailableProject.Controls.Add(this.tabExpireProject);
            this.tabAvailableProject.Controls.Add(this.tabAvailableTopic);
            this.tabAvailableProject.Controls.Add(this.tabExpireTopic);
            this.tabAvailableProject.Controls.Add(this.tabSubject);
            this.tabAvailableProject.Location = new System.Drawing.Point(17, 67);
            this.tabAvailableProject.Name = "tabAvailableProject";
            this.tabAvailableProject.SelectedIndex = 0;
            this.tabAvailableProject.Size = new System.Drawing.Size(655, 332);
            this.tabAvailableProject.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đồ án đang có";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabExpireProject
            // 
            this.tabExpireProject.Location = new System.Drawing.Point(4, 22);
            this.tabExpireProject.Name = "tabExpireProject";
            this.tabExpireProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpireProject.Size = new System.Drawing.Size(647, 306);
            this.tabExpireProject.TabIndex = 1;
            this.tabExpireProject.Text = "Đồ án đã hết hạn";
            this.tabExpireProject.UseVisualStyleBackColor = true;
            // 
            // tabAvailableTopic
            // 
            this.tabAvailableTopic.Location = new System.Drawing.Point(4, 22);
            this.tabAvailableTopic.Name = "tabAvailableTopic";
            this.tabAvailableTopic.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailableTopic.Size = new System.Drawing.Size(647, 306);
            this.tabAvailableTopic.TabIndex = 2;
            this.tabAvailableTopic.Text = "Đề tài đang có";
            this.tabAvailableTopic.UseVisualStyleBackColor = true;
            // 
            // tabExpireTopic
            // 
            this.tabExpireTopic.Location = new System.Drawing.Point(4, 22);
            this.tabExpireTopic.Name = "tabExpireTopic";
            this.tabExpireTopic.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpireTopic.Size = new System.Drawing.Size(647, 306);
            this.tabExpireTopic.TabIndex = 3;
            this.tabExpireTopic.Text = "Đề tài hết hạn";
            this.tabExpireTopic.UseVisualStyleBackColor = true;
            // 
            // tabSubject
            // 
            this.tabSubject.Location = new System.Drawing.Point(4, 22);
            this.tabSubject.Name = "tabSubject";
            this.tabSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubject.Size = new System.Drawing.Size(647, 306);
            this.tabSubject.TabIndex = 4;
            this.tabSubject.Text = "Danh sách môn học";
            this.tabSubject.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tabAvailableProject);
            this.Name = "Overview";
            this.Text = "Tổng quan";
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.tabAvailableProject, 0);
            this.tabAvailableProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAvailableProject;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabExpireProject;
        private System.Windows.Forms.TabPage tabAvailableTopic;
        private System.Windows.Forms.TabPage tabExpireTopic;
        private System.Windows.Forms.TabPage tabSubject;
    }
}