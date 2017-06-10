namespace HQT
{
    partial class CreateSubjectForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvTeacher = new System.Windows.Forms.ListView();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvTeacher);
            this.groupBox2.Location = new System.Drawing.Point(17, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giáo viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvStudent);
            this.groupBox3.Location = new System.Drawing.Point(343, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinh viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 373);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvTeacher
            // 
            this.lvTeacher.CheckBoxes = true;
            this.lvTeacher.Location = new System.Drawing.Point(15, 19);
            this.lvTeacher.Name = "lvTeacher";
            this.lvTeacher.Size = new System.Drawing.Size(289, 152);
            this.lvTeacher.TabIndex = 0;
            this.lvTeacher.UseCompatibleStateImageBehavior = false;
            this.lvTeacher.View = System.Windows.Forms.View.List;
            // 
            // lvStudent
            // 
            this.lvStudent.CheckBoxes = true;
            this.lvStudent.Location = new System.Drawing.Point(18, 19);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(291, 152);
            this.lvStudent.TabIndex = 0;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học :";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(94, 23);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(541, 20);
            this.txtSubjectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả :";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(94, 53);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(541, 48);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // CreateSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm môn học";
            this.Load += new System.EventHandler(this.CreateSubjectForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvTeacher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}