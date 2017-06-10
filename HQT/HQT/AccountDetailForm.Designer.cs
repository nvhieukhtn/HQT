namespace HQT
{
    partial class AccountDetailForm
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
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnEditPhone = new System.Windows.Forms.Button();
            this.btnSavePhone = new System.Windows.Forms.Button();
            this.btnSaveAddress = new System.Windows.Forms.Button();
            this.btnSaveFullname = new System.Windows.Forms.Button();
            this.btnEditFullname = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Load += new System.EventHandler(this.statusBar_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAccountType);
            this.groupBox1.Controls.Add(this.txtRePassword);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.btnChangeAvatar);
            this.groupBox1.Controls.Add(this.btnEditAddress);
            this.groupBox1.Controls.Add(this.btnEditPhone);
            this.groupBox1.Controls.Add(this.btnSavePhone);
            this.groupBox1.Controls.Add(this.btnSaveAddress);
            this.groupBox1.Controls.Add(this.btnSaveFullname);
            this.groupBox1.Controls.Add(this.btnEditFullname);
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cbAccountType
            // 
            this.cbAccountType.Enabled = false;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.cbAccountType.Location = new System.Drawing.Point(236, 76);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(299, 21);
            this.cbAccountType.TabIndex = 2;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(397, 272);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(138, 20);
            this.txtRePassword.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(16, 235);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(116, 23);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.Location = new System.Drawing.Point(45, 185);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(63, 24);
            this.btnChangeAvatar.TabIndex = 5;
            this.btnChangeAvatar.Text = "Thay đổi";
            this.btnChangeAvatar.UseVisualStyleBackColor = true;
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.BackgroundImage = global::HQT.Properties.Resources.edit;
            this.btnEditAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAddress.FlatAppearance.BorderSize = 0;
            this.btnEditAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAddress.Location = new System.Drawing.Point(541, 235);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(20, 20);
            this.btnEditAddress.TabIndex = 4;
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // btnEditPhone
            // 
            this.btnEditPhone.BackgroundImage = global::HQT.Properties.Resources.edit;
            this.btnEditPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPhone.FlatAppearance.BorderSize = 0;
            this.btnEditPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPhone.Location = new System.Drawing.Point(541, 193);
            this.btnEditPhone.Name = "btnEditPhone";
            this.btnEditPhone.Size = new System.Drawing.Size(20, 20);
            this.btnEditPhone.TabIndex = 4;
            this.btnEditPhone.UseVisualStyleBackColor = true;
            this.btnEditPhone.Click += new System.EventHandler(this.btnEditPhone_Click);
            // 
            // btnSavePhone
            // 
            this.btnSavePhone.BackgroundImage = global::HQT.Properties.Resources.save;
            this.btnSavePhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePhone.FlatAppearance.BorderSize = 0;
            this.btnSavePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePhone.Location = new System.Drawing.Point(541, 193);
            this.btnSavePhone.Name = "btnSavePhone";
            this.btnSavePhone.Size = new System.Drawing.Size(20, 20);
            this.btnSavePhone.TabIndex = 4;
            this.btnSavePhone.UseVisualStyleBackColor = true;
            this.btnSavePhone.Visible = false;
            this.btnSavePhone.Click += new System.EventHandler(this.btnSavePhone_Click);
            // 
            // btnSaveAddress
            // 
            this.btnSaveAddress.BackgroundImage = global::HQT.Properties.Resources.save;
            this.btnSaveAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveAddress.FlatAppearance.BorderSize = 0;
            this.btnSaveAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddress.Location = new System.Drawing.Point(541, 234);
            this.btnSaveAddress.Name = "btnSaveAddress";
            this.btnSaveAddress.Size = new System.Drawing.Size(20, 20);
            this.btnSaveAddress.TabIndex = 4;
            this.btnSaveAddress.UseVisualStyleBackColor = true;
            this.btnSaveAddress.Visible = false;
            this.btnSaveAddress.Click += new System.EventHandler(this.btnSaveAddress_Click);
            // 
            // btnSaveFullname
            // 
            this.btnSaveFullname.BackgroundImage = global::HQT.Properties.Resources.save;
            this.btnSaveFullname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFullname.FlatAppearance.BorderSize = 0;
            this.btnSaveFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFullname.Location = new System.Drawing.Point(541, 116);
            this.btnSaveFullname.Name = "btnSaveFullname";
            this.btnSaveFullname.Size = new System.Drawing.Size(20, 20);
            this.btnSaveFullname.TabIndex = 4;
            this.btnSaveFullname.UseVisualStyleBackColor = true;
            this.btnSaveFullname.Visible = false;
            this.btnSaveFullname.Click += new System.EventHandler(this.btnSaveFullname_Click);
            // 
            // btnEditFullname
            // 
            this.btnEditFullname.BackgroundImage = global::HQT.Properties.Resources.edit;
            this.btnEditFullname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditFullname.FlatAppearance.BorderSize = 0;
            this.btnEditFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFullname.Location = new System.Drawing.Point(541, 116);
            this.btnEditFullname.Name = "btnEditFullname";
            this.btnEditFullname.Size = new System.Drawing.Size(20, 20);
            this.btnEditFullname.TabIndex = 4;
            this.btnEditFullname.UseVisualStyleBackColor = true;
            this.btnEditFullname.Click += new System.EventHandler(this.btnEditFullname_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImage = global::HQT.Properties.Resources.avatar;
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Location = new System.Drawing.Point(16, 44);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(116, 135);
            this.picAvatar.TabIndex = 3;
            this.picAvatar.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(236, 272);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(236, 235);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(299, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(236, 193);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(299, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(236, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(148, 275);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(52, 13);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtFullname
            // 
            this.txtFullname.Enabled = false;
            this.txtFullname.Location = new System.Drawing.Point(236, 116);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(299, 20);
            this.txtFullname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(236, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(299, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại TK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // AccountDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountDetailForm_FormClosing);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.Button btnEditPhone;
        private System.Windows.Forms.Button btnEditFullname;
        private System.Windows.Forms.Button btnSavePhone;
        private System.Windows.Forms.Button btnSaveAddress;
        private System.Windows.Forms.Button btnSaveFullname;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label label2;
    }
}