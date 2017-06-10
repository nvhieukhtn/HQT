namespace HQT
{
    partial class ProjectDetailForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProjectType = new System.Windows.Forms.ComboBox();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.numberGroup = new System.Windows.Forms.NumericUpDown();
            this.numberTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProjectType);
            this.groupBox1.Controls.Add(this.btnAddTopic);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.numberGroup);
            this.groupBox1.Controls.Add(this.numberTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtDeadline);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Location = new System.Drawing.Point(11, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 86);
            this.groupBox1.TabIndex = 4;
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
            // btnAddTopic
            // 
            this.btnAddTopic.BackgroundImage = global::HQT.Properties.Resources.add_project;
            this.btnAddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTopic.FlatAppearance.BorderSize = 0;
            this.btnAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopic.Location = new System.Drawing.Point(615, 12);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(30, 30);
            this.btnAddTopic.TabIndex = 7;
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::HQT.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(615, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::HQT.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(615, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEdit_MouseClick);
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
            // ProjectDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ án";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectDetail_FormClosed);
            this.Load += new System.EventHandler(this.ProjectDetailForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbProjectType;
        private System.Windows.Forms.Button btnAddTopic;
    }
}