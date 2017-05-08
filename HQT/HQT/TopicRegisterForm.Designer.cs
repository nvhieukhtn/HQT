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
            this.gbGroupInformation = new System.Windows.Forms.GroupBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTopicInformation.SuspendLayout();
            this.gbGroupInformation.SuspendLayout();
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
            this.gbTopicInformation.Location = new System.Drawing.Point(12, 53);
            this.gbTopicInformation.Name = "gbTopicInformation";
            this.gbTopicInformation.Size = new System.Drawing.Size(660, 128);
            this.gbTopicInformation.TabIndex = 1;
            this.gbTopicInformation.TabStop = false;
            this.gbTopicInformation.Text = "Thông tin đề bài";
            // 
            // gbGroupInformation
            // 
            this.gbGroupInformation.Controls.Add(this.btnAddMember);
            this.gbGroupInformation.Location = new System.Drawing.Point(12, 187);
            this.gbGroupInformation.Name = "gbGroupInformation";
            this.gbGroupInformation.Size = new System.Drawing.Size(660, 168);
            this.gbGroupInformation.TabIndex = 1;
            this.gbGroupInformation.TabStop = false;
            this.gbGroupInformation.Text = "Thông tin đăng ký";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackgroundImage = global::HQT.Properties.Resources.add_member;
            this.btnAddMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Location = new System.Drawing.Point(623, 13);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(30, 30);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRegister.Location = new System.Drawing.Point(290, 364);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 38);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = false;
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
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(77, 45);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(561, 77);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
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
            // TopicRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbGroupInformation);
            this.Controls.Add(this.gbTopicInformation);
            this.Name = "TopicRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký đồ án";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopicRegisterForm_FormClosing);
            this.Controls.SetChildIndex(this.gbTopicInformation, 0);
            this.Controls.SetChildIndex(this.gbGroupInformation, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.btnRegister, 0);
            this.gbTopicInformation.ResumeLayout(false);
            this.gbTopicInformation.PerformLayout();
            this.gbGroupInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTopicInformation;
        private System.Windows.Forms.GroupBox gbGroupInformation;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label2;
    }
}