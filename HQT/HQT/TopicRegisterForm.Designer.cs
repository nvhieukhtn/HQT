namespace HQT
{
    partial class TopicRegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbTopicInformation = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProjectType = new System.Windows.Forms.ComboBox();
            this.numberGroup = new System.Windows.Forms.NumericUpDown();
            this.numberTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.grbGroup = new System.Windows.Forms.GroupBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.txtCountRemainder = new System.Windows.Forms.TextBox();
            this.txtCountNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbTopicInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTo)).BeginInit();
            this.grbGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề : ";
            // 
            // gbTopicInformation
            // 
            this.gbTopicInformation.Controls.Add(this.txtContent);
            this.gbTopicInformation.Controls.Add(this.txtTitle);
            this.gbTopicInformation.Controls.Add(this.label2);
            this.gbTopicInformation.Controls.Add(this.label1);
            this.gbTopicInformation.Location = new System.Drawing.Point(12, 145);
            this.gbTopicInformation.Name = "gbTopicInformation";
            this.gbTopicInformation.Size = new System.Drawing.Size(660, 128);
            this.gbTopicInformation.TabIndex = 1;
            this.gbTopicInformation.TabStop = false;
            this.gbTopicInformation.Text = "Thông tin đề bài";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(77, 45);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(561, 77);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTitle.Location = new System.Drawing.Point(77, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(561, 13);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nội dung : ";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRegister.Location = new System.Drawing.Point(291, 352);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 38);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProjectType);
            this.groupBox1.Controls.Add(this.numberGroup);
            this.groupBox1.Controls.Add(this.numberTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtDeadline);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbProjectType
            // 
            this.cbProjectType.Enabled = false;
            this.cbProjectType.FormattingEnabled = true;
            this.cbProjectType.Location = new System.Drawing.Point(478, 20);
            this.cbProjectType.Name = "cbProjectType";
            this.cbProjectType.Size = new System.Drawing.Size(121, 21);
            this.cbProjectType.TabIndex = 8;
            // 
            // numberGroup
            // 
            this.numberGroup.Enabled = false;
            this.numberGroup.InterceptArrowKeys = false;
            this.numberGroup.Location = new System.Drawing.Point(100, 56);
            this.numberGroup.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberGroup.Name = "numberGroup";
            this.numberGroup.ReadOnly = true;
            this.numberGroup.Size = new System.Drawing.Size(94, 20);
            this.numberGroup.TabIndex = 6;
            this.numberGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberTo
            // 
            this.numberTo.Enabled = false;
            this.numberTo.Location = new System.Drawing.Point(265, 56);
            this.numberTo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberTo.Name = "numberTo";
            this.numberTo.ReadOnly = true;
            this.numberTo.Size = new System.Drawing.Size(95, 20);
            this.numberTo.TabIndex = 6;
            this.numberTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng nhóm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số người :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn nộp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại :";
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtTo.Enabled = false;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(239, 19);
            this.dtTo.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(121, 20);
            this.dtTo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thời gian :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đến";
            // 
            // dtDeadline
            // 
            this.dtDeadline.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtDeadline.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtDeadline.Enabled = false;
            this.dtDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeadline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDeadline.Location = new System.Drawing.Point(478, 52);
            this.dtDeadline.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtDeadline.MinDate = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtDeadline.Name = "dtDeadline";
            this.dtDeadline.Size = new System.Drawing.Size(121, 20);
            this.dtDeadline.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtFrom.Enabled = false;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtFrom.Location = new System.Drawing.Point(73, 19);
            this.dtFrom.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(121, 20);
            this.dtFrom.TabIndex = 1;
            // 
            // grbGroup
            // 
            this.grbGroup.Controls.Add(this.txtGroupName);
            this.grbGroup.Controls.Add(this.lvStudent);
            this.grbGroup.Controls.Add(this.txtCountRemainder);
            this.grbGroup.Controls.Add(this.txtCountNumber);
            this.grbGroup.Controls.Add(this.label11);
            this.grbGroup.Controls.Add(this.label10);
            this.grbGroup.Controls.Add(this.label12);
            this.grbGroup.Controls.Add(this.label9);
            this.grbGroup.Location = new System.Drawing.Point(12, 279);
            this.grbGroup.Name = "grbGroup";
            this.grbGroup.Size = new System.Drawing.Size(660, 65);
            this.grbGroup.TabIndex = 6;
            this.grbGroup.TabStop = false;
            this.grbGroup.Text = "Thông tin nhóm";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(114, 16);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(246, 20);
            this.txtGroupName.TabIndex = 3;
            // 
            // lvStudent
            // 
            this.lvStudent.CheckBoxes = true;
            this.lvStudent.Location = new System.Drawing.Point(433, 10);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(205, 49);
            this.lvStudent.TabIndex = 2;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.List;
            this.lvStudent.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudent_ItemChecked);
            // 
            // txtCountRemainder
            // 
            this.txtCountRemainder.Enabled = false;
            this.txtCountRemainder.Location = new System.Drawing.Point(313, 40);
            this.txtCountRemainder.Name = "txtCountRemainder";
            this.txtCountRemainder.Size = new System.Drawing.Size(48, 20);
            this.txtCountRemainder.TabIndex = 1;
            // 
            // txtCountNumber
            // 
            this.txtCountNumber.Enabled = false;
            this.txtCountNumber.Location = new System.Drawing.Point(114, 40);
            this.txtCountNumber.Name = "txtCountNumber";
            this.txtCountNumber.Size = new System.Drawing.Size(48, 20);
            this.txtCountNumber.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thành viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên nhóm : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng còn lại :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng tối đa :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(352, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemove.Location = new System.Drawing.Point(231, 352);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 38);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Hủy";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TopicRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.grbGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbTopicInformation);
            this.Name = "TopicRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký đồ án";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopicRegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.TopicRegisterForm_Load);
            this.Controls.SetChildIndex(this.gbTopicInformation, 0);
            this.Controls.SetChildIndex(this.btnRegister, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.grbGroup, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.gbTopicInformation.ResumeLayout(false);
            this.gbTopicInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTo)).EndInit();
            this.grbGroup.ResumeLayout(false);
            this.grbGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTopicInformation;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProjectType;
        private System.Windows.Forms.NumericUpDown numberGroup;
        private System.Windows.Forms.NumericUpDown numberTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.GroupBox grbGroup;
        private System.Windows.Forms.TextBox txtCountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCountRemainder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}