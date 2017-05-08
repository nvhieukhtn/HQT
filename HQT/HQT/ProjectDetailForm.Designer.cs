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
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.btnStatus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberGroup = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberFrom = new System.Windows.Forms.NumericUpDown();
            this.numberTo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFrom)).BeginInit();
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
            // timeFrom
            // 
            this.timeFrom.Checked = false;
            this.timeFrom.CustomFormat = "dd.MM.yyyy HH:ss";
            this.timeFrom.Enabled = false;
            this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom.Location = new System.Drawing.Point(73, 19);
            this.timeFrom.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timeFrom.MinDate = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(121, 20);
            this.timeFrom.TabIndex = 1;
            // 
            // timeTo
            // 
            this.timeTo.Checked = false;
            this.timeTo.CustomFormat = "dd.MM.yyyy HH:ss";
            this.timeTo.Enabled = false;
            this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo.Location = new System.Drawing.Point(239, 19);
            this.timeTo.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timeTo.MinDate = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(121, 20);
            this.timeTo.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Lime;
            this.btnStatus.Enabled = false;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatus.Location = new System.Drawing.Point(484, 18);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(115, 23);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "PROCESSING";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberGroup);
            this.groupBox1.Controls.Add(this.numberTo);
            this.groupBox1.Controls.Add(this.numberFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeTo);
            this.groupBox1.Controls.Add(this.btnStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.timeFrom);
            this.groupBox1.Location = new System.Drawing.Point(11, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // numberGroup
            // 
            this.numberGroup.Enabled = false;
            this.numberGroup.InterceptArrowKeys = false;
            this.numberGroup.Location = new System.Drawing.Point(484, 56);
            this.numberGroup.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberGroup.Name = "numberGroup";
            this.numberGroup.ReadOnly = true;
            this.numberGroup.Size = new System.Drawing.Size(115, 20);
            this.numberGroup.TabIndex = 6;
            this.numberGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng nhóm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số người :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đến";
            // 
            // numberFrom
            // 
            this.numberFrom.Enabled = false;
            this.numberFrom.Location = new System.Drawing.Point(73, 56);
            this.numberFrom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberFrom.Name = "numberFrom";
            this.numberFrom.ReadOnly = true;
            this.numberFrom.Size = new System.Drawing.Size(120, 20);
            this.numberFrom.TabIndex = 6;
            this.numberFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberTo
            // 
            this.numberTo.Enabled = false;
            this.numberTo.Location = new System.Drawing.Point(240, 56);
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
            this.numberTo.Size = new System.Drawing.Size(120, 20);
            this.numberTo.TabIndex = 6;
            this.numberTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberTo;
        private System.Windows.Forms.NumericUpDown numberFrom;
    }
}