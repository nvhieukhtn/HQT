namespace HQT
{
    partial class SubjectBoard
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
            this.grbSubject = new System.Windows.Forms.GroupBox();
            this.grbProjects = new System.Windows.Forms.GroupBox();
            this.cbColleage = new System.Windows.Forms.ComboBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.grbSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSubject
            // 
            this.grbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSubject.Controls.Add(this.grbProjects);
            this.grbSubject.Controls.Add(this.cbColleage);
            this.grbSubject.Controls.Add(this.txtSubjectName);
            this.grbSubject.Controls.Add(this.label1);
            this.grbSubject.Controls.Add(this.lbSubject);
            this.grbSubject.Location = new System.Drawing.Point(2, -4);
            this.grbSubject.Name = "grbSubject";
            this.grbSubject.Size = new System.Drawing.Size(660, 90);
            this.grbSubject.TabIndex = 1;
            this.grbSubject.TabStop = false;
            // 
            // grbProjects
            // 
            this.grbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProjects.Location = new System.Drawing.Point(344, 7);
            this.grbProjects.Name = "grbProjects";
            this.grbProjects.Size = new System.Drawing.Size(310, 81);
            this.grbProjects.TabIndex = 3;
            this.grbProjects.TabStop = false;
            this.grbProjects.Text = "Đồ án";
            // 
            // cbColleage
            // 
            this.cbColleage.FormattingEnabled = true;
            this.cbColleage.Location = new System.Drawing.Point(99, 59);
            this.cbColleage.Name = "cbColleage";
            this.cbColleage.Size = new System.Drawing.Size(216, 21);
            this.cbColleage.TabIndex = 2;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Enabled = false;
            this.txtSubjectName.Location = new System.Drawing.Point(99, 18);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(216, 20);
            this.txtSubjectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên : ";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSubject.Location = new System.Drawing.Point(16, 19);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(68, 16);
            this.lbSubject.TabIndex = 0;
            this.lbSubject.Text = "Môn học : ";
            // 
            // SubjectBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbSubject);
            this.Name = "SubjectBoard";
            this.Size = new System.Drawing.Size(663, 87);
            this.grbSubject.ResumeLayout(false);
            this.grbSubject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSubject;
        private System.Windows.Forms.ComboBox cbColleage;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.GroupBox grbProjects;
    }
}
