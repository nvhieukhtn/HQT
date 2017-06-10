namespace HQT
{
    partial class TabTopicContentUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.ckAddNew = new System.Windows.Forms.CheckBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Lavender;
            this.txtTitle.Location = new System.Drawing.Point(69, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(491, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nội dung";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Lavender;
            this.txtContent.Location = new System.Drawing.Point(69, 50);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(548, 123);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // ckAddNew
            // 
            this.ckAddNew.AutoSize = true;
            this.ckAddNew.Checked = true;
            this.ckAddNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAddNew.Location = new System.Drawing.Point(569, 16);
            this.ckAddNew.Name = "ckAddNew";
            this.ckAddNew.Size = new System.Drawing.Size(72, 17);
            this.ckAddNew.TabIndex = 3;
            this.ckAddNew.Text = "Thêm mới";
            this.ckAddNew.UseVisualStyleBackColor = true;
            this.ckAddNew.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbTitle
            // 
            this.cbTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(69, 14);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(491, 21);
            this.cbTitle.TabIndex = 4;
            this.cbTitle.Visible = false;
            this.cbTitle.SelectedIndexChanged += new System.EventHandler(this.cbTitle_SelectedIndexChanged);
            // 
            // TabTopicContentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.ckAddNew);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TabTopicContentUserControl";
            this.Size = new System.Drawing.Size(641, 184);
            this.Load += new System.EventHandler(this.TabTopicContentUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.CheckBox ckAddNew;
        private System.Windows.Forms.ComboBox cbTitle;
    }
}
