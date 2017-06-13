namespace HQT
{
    partial class TopicUserControl
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
            this.grbPractice = new System.Windows.Forms.GroupBox();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbPractice.SuspendLayout();
            this.grbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPractice
            // 
            this.grbPractice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPractice.Controls.Add(this.btnMembers);
            this.grbPractice.Controls.Add(this.btnRemove);
            this.grbPractice.Controls.Add(this.btnRegister);
            this.grbPractice.Controls.Add(this.btnTitle);
            this.grbPractice.Controls.Add(this.grbDetail);
            this.grbPractice.Controls.Add(this.lbTitle);
            this.grbPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbPractice.Location = new System.Drawing.Point(0, 0);
            this.grbPractice.Name = "grbPractice";
            this.grbPractice.Size = new System.Drawing.Size(660, 90);
            this.grbPractice.TabIndex = 0;
            this.grbPractice.TabStop = false;
            this.grbPractice.Text = "Đề bài";
            // 
            // btnMembers
            // 
            this.btnMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMembers.BackgroundImage = global::HQT.Properties.Resources.account;
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Location = new System.Drawing.Point(568, 19);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(30, 30);
            this.btnMembers.TabIndex = 4;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Visible = false;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackgroundImage = global::HQT.Properties.Resources.delete;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(601, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackgroundImage = global::HQT.Properties.Resources.register;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(568, 18);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(30, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTitle.CausesValidation = false;
            this.btnTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Location = new System.Drawing.Point(80, 22);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(482, 23);
            this.btnTitle.TabIndex = 3;
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // grbDetail
            // 
            this.grbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDetail.Controls.Add(this.txtDetail);
            this.grbDetail.Location = new System.Drawing.Point(20, 49);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(611, 35);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            this.grbDetail.Visible = false;
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDetail.Enabled = false;
            this.txtDetail.Location = new System.Drawing.Point(12, 14);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(589, 15);
            this.txtDetail.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(18, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(57, 15);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tiêu đề : ";
            // 
            // TopicUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPractice);
            this.Name = "TopicUserControl";
            this.Size = new System.Drawing.Size(660, 90);
            this.Load += new System.EventHandler(this.TopicUserControl_Load);
            this.grbPractice.ResumeLayout(false);
            this.grbPractice.PerformLayout();
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPractice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMembers;
    }
}
