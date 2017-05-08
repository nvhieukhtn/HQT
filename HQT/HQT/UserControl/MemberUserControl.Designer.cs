namespace HQT
{
    partial class MemberUserControl
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
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.ckLeader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(3, 3);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(163, 21);
            this.cbStudent.TabIndex = 0;
            this.cbStudent.Text = "Sinh viên";
            // 
            // ckLeader
            // 
            this.ckLeader.AutoSize = true;
            this.ckLeader.Location = new System.Drawing.Point(172, 5);
            this.ckLeader.Name = "ckLeader";
            this.ckLeader.Size = new System.Drawing.Size(87, 17);
            this.ckLeader.TabIndex = 1;
            this.ckLeader.Text = "Nhóm trưởng";
            this.ckLeader.UseVisualStyleBackColor = true;
            // 
            // MemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckLeader);
            this.Controls.Add(this.cbStudent);
            this.Name = "MemberUserControl";
            this.Size = new System.Drawing.Size(262, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.CheckBox ckLeader;
    }
}
