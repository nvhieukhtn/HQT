namespace HQT
{
    partial class CreateProjectForm
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
            this.cbProjectType = new System.Windows.Forms.ComboBox();
            this.numberGroup = new System.Windows.Forms.NumericUpDown();
            this.numberStudentMax = new System.Windows.Forms.NumericUpDown();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGroupNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumberPeopleMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTopic = new System.Windows.Forms.TabControl();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStudentMax)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Load += new System.EventHandler(this.statusBar_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProjectType);
            this.groupBox1.Controls.Add(this.numberGroup);
            this.groupBox1.Controls.Add(this.numberStudentMax);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtDeadline);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.btnAddTopic);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbGroupNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbNumberPeopleMin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbProjectType
            // 
            this.cbProjectType.FormattingEnabled = true;
            this.cbProjectType.Location = new System.Drawing.Point(91, 43);
            this.cbProjectType.Name = "cbProjectType";
            this.cbProjectType.Size = new System.Drawing.Size(121, 21);
            this.cbProjectType.TabIndex = 7;
            // 
            // numberGroup
            // 
            this.numberGroup.Location = new System.Drawing.Point(304, 45);
            this.numberGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberGroup.Name = "numberGroup";
            this.numberGroup.Size = new System.Drawing.Size(42, 20);
            this.numberGroup.TabIndex = 5;
            this.numberGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberStudentMax
            // 
            this.numberStudentMax.Location = new System.Drawing.Point(513, 44);
            this.numberStudentMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberStudentMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberStudentMax.Name = "numberStudentMax";
            this.numberStudentMax.Size = new System.Drawing.Size(38, 20);
            this.numberStudentMax.TabIndex = 5;
            this.numberStudentMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(251, 72);
            this.dtTo.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(128, 20);
            this.dtTo.TabIndex = 4;
            // 
            // dtDeadline
            // 
            this.dtDeadline.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeadline.Location = new System.Drawing.Point(486, 72);
            this.dtDeadline.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtDeadline.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDeadline.Name = "dtDeadline";
            this.dtDeadline.Size = new System.Drawing.Size(128, 20);
            this.dtDeadline.TabIndex = 4;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(91, 72);
            this.dtFrom.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(128, 20);
            this.dtFrom.TabIndex = 4;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackgroundImage = global::HQT.Properties.Resources.add_project;
            this.btnAddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTopic.FlatAppearance.BorderSize = 0;
            this.btnAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopic.Location = new System.Drawing.Point(620, 20);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(20, 20);
            this.btnAddTopic.TabIndex = 3;
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(91, 20);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(523, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến";
            // 
            // lbGroupNumber
            // 
            this.lbGroupNumber.AutoSize = true;
            this.lbGroupNumber.Location = new System.Drawing.Point(220, 47);
            this.lbGroupNumber.Name = "lbGroupNumber";
            this.lbGroupNumber.Size = new System.Drawing.Size(78, 13);
            this.lbGroupNumber.TabIndex = 0;
            this.lbGroupNumber.Text = "Số lượng nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hạn nộp";
            // 
            // lbNumberPeopleMin
            // 
            this.lbNumberPeopleMin.AutoSize = true;
            this.lbNumberPeopleMin.Location = new System.Drawing.Point(429, 47);
            this.lbNumberPeopleMin.Name = "lbNumberPeopleMin";
            this.lbNumberPeopleMin.Size = new System.Drawing.Size(78, 13);
            this.lbNumberPeopleMin.TabIndex = 0;
            this.lbNumberPeopleMin.Text = "Số lượng người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại đồ án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đồ án";
            // 
            // tabTopic
            // 
            this.tabTopic.Location = new System.Drawing.Point(18, 161);
            this.tabTopic.Name = "tabTopic";
            this.tabTopic.SelectedIndex = 0;
            this.tabTopic.Size = new System.Drawing.Size(649, 210);
            this.tabTopic.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(310, 374);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabTopic);
            this.Name = "CreateProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đồ án mới";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateProjectForm_FormClosing);
            this.Controls.SetChildIndex(this.tabTopic, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCreate, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStudentMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabTopic;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberStudentMax;
        private System.Windows.Forms.Label lbNumberPeopleMin;
        private System.Windows.Forms.Label lbGroupNumber;
        private System.Windows.Forms.NumericUpDown numberGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProjectType;
    }
}