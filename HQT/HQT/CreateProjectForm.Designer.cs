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
            this.ckLimit = new System.Windows.Forms.CheckBox();
            this.radioPersonal = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.RadioButton();
            this.numberGroup = new System.Windows.Forms.NumericUpDown();
            this.numberPeopleMax = new System.Windows.Forms.NumericUpDown();
            this.numberPeopleMin = new System.Windows.Forms.NumericUpDown();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lbNumberPeopleMax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGroupNumber = new System.Windows.Forms.Label();
            this.lbNumberPeopleMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTopic = new System.Windows.Forms.TabControl();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleMin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckLimit);
            this.groupBox1.Controls.Add(this.radioPersonal);
            this.groupBox1.Controls.Add(this.radioGroup);
            this.groupBox1.Controls.Add(this.numberGroup);
            this.groupBox1.Controls.Add(this.numberPeopleMax);
            this.groupBox1.Controls.Add(this.numberPeopleMin);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.btnAddTopic);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.lbNumberPeopleMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbGroupNumber);
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
            // ckLimit
            // 
            this.ckLimit.AutoSize = true;
            this.ckLimit.Location = new System.Drawing.Point(243, 46);
            this.ckLimit.Name = "ckLimit";
            this.ckLimit.Size = new System.Drawing.Size(94, 17);
            this.ckLimit.TabIndex = 7;
            this.ckLimit.Text = "Giới hạn nhóm";
            this.ckLimit.UseVisualStyleBackColor = true;
            this.ckLimit.CheckedChanged += new System.EventHandler(this.ckLimit_CheckedChanged);
            // 
            // radioPersonal
            // 
            this.radioPersonal.AutoSize = true;
            this.radioPersonal.Location = new System.Drawing.Point(163, 45);
            this.radioPersonal.Name = "radioPersonal";
            this.radioPersonal.Size = new System.Drawing.Size(65, 17);
            this.radioPersonal.TabIndex = 6;
            this.radioPersonal.TabStop = true;
            this.radioPersonal.Text = "Cá nhân";
            this.radioPersonal.UseVisualStyleBackColor = true;
            this.radioPersonal.CheckedChanged += new System.EventHandler(this.radioPersonal_CheckedChanged);
            // 
            // radioGroup
            // 
            this.radioGroup.AutoSize = true;
            this.radioGroup.Location = new System.Drawing.Point(91, 45);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(53, 17);
            this.radioGroup.TabIndex = 6;
            this.radioGroup.TabStop = true;
            this.radioGroup.Text = "Nhóm";
            this.radioGroup.UseVisualStyleBackColor = true;
            this.radioGroup.CheckedChanged += new System.EventHandler(this.radioGroup_CheckedChanged);
            // 
            // numberGroup
            // 
            this.numberGroup.Location = new System.Drawing.Point(450, 45);
            this.numberGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberGroup.Name = "numberGroup";
            this.numberGroup.Size = new System.Drawing.Size(38, 20);
            this.numberGroup.TabIndex = 5;
            this.numberGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberPeopleMax
            // 
            this.numberPeopleMax.Location = new System.Drawing.Point(539, 72);
            this.numberPeopleMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberPeopleMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPeopleMax.Name = "numberPeopleMax";
            this.numberPeopleMax.Size = new System.Drawing.Size(38, 20);
            this.numberPeopleMax.TabIndex = 5;
            this.numberPeopleMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberPeopleMin
            // 
            this.numberPeopleMin.Location = new System.Drawing.Point(450, 72);
            this.numberPeopleMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberPeopleMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPeopleMin.Name = "numberPeopleMin";
            this.numberPeopleMin.Size = new System.Drawing.Size(38, 20);
            this.numberPeopleMin.TabIndex = 5;
            this.numberPeopleMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(232, 72);
            this.dtTo.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(128, 20);
            this.dtTo.TabIndex = 4;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(72, 72);
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
            // lbNumberPeopleMax
            // 
            this.lbNumberPeopleMax.AutoSize = true;
            this.lbNumberPeopleMax.Location = new System.Drawing.Point(500, 76);
            this.lbNumberPeopleMax.Name = "lbNumberPeopleMax";
            this.lbNumberPeopleMax.Size = new System.Drawing.Size(27, 13);
            this.lbNumberPeopleMax.TabIndex = 0;
            this.lbNumberPeopleMax.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến";
            // 
            // lbGroupNumber
            // 
            this.lbGroupNumber.AutoSize = true;
            this.lbGroupNumber.Location = new System.Drawing.Point(366, 47);
            this.lbGroupNumber.Name = "lbGroupNumber";
            this.lbGroupNumber.Size = new System.Drawing.Size(78, 13);
            this.lbGroupNumber.TabIndex = 0;
            this.lbGroupNumber.Text = "Số lượng nhóm";
            // 
            // lbNumberPeopleMin
            // 
            this.lbNumberPeopleMin.AutoSize = true;
            this.lbNumberPeopleMin.Location = new System.Drawing.Point(366, 75);
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
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleMin)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numberPeopleMax;
        private System.Windows.Forms.NumericUpDown numberPeopleMin;
        private System.Windows.Forms.Label lbNumberPeopleMax;
        private System.Windows.Forms.Label lbNumberPeopleMin;
        private System.Windows.Forms.Label lbGroupNumber;
        private System.Windows.Forms.NumericUpDown numberGroup;
        private System.Windows.Forms.RadioButton radioPersonal;
        private System.Windows.Forms.RadioButton radioGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckLimit;
    }
}