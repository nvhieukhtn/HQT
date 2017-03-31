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
            this.btnStatus = new System.Windows.Forms.Button();
            this.cbColleage = new System.Windows.Forms.ComboBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtProjectCount = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.grbSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSubject
            // 
            this.grbSubject.Controls.Add(this.btnStatus);
            this.grbSubject.Controls.Add(this.cbColleage);
            this.grbSubject.Controls.Add(this.btnDetail);
            this.grbSubject.Controls.Add(this.txtProjectCount);
            this.grbSubject.Controls.Add(this.txtSubjectName);
            this.grbSubject.Controls.Add(this.label1);
            this.grbSubject.Controls.Add(this.label3);
            this.grbSubject.Controls.Add(this.label2);
            this.grbSubject.Controls.Add(this.lbSubject);
            this.grbSubject.Location = new System.Drawing.Point(2, -4);
            this.grbSubject.Name = "grbSubject";
            this.grbSubject.Size = new System.Drawing.Size(660, 91);
            this.grbSubject.TabIndex = 1;
            this.grbSubject.TabStop = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Lime;
            this.btnStatus.Enabled = false;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Location = new System.Drawing.Point(453, 57);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Đang học";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // cbColleage
            // 
            this.cbColleage.FormattingEnabled = true;
            this.cbColleage.Location = new System.Drawing.Point(99, 59);
            this.cbColleage.Name = "cbColleage";
            this.cbColleage.Size = new System.Drawing.Size(216, 21);
            this.cbColleage.TabIndex = 2;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(571, 18);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(61, 20);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // txtProjectCount
            // 
            this.txtProjectCount.Enabled = false;
            this.txtProjectCount.Location = new System.Drawing.Point(433, 18);
            this.txtProjectCount.Name = "txtProjectCount";
            this.txtProjectCount.Size = new System.Drawing.Size(118, 20);
            this.txtProjectCount.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(356, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(356, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đồ án : ";
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
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.ComboBox cbColleage;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtProjectCount;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSubject;
    }
}
