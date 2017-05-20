namespace HQT
{
    partial class StatusBarUserControl
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
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = global::HQT.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(19, 1);
            this.picHome.Margin = new System.Windows.Forms.Padding(0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(40, 40);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::HQT.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(590, 0);
            this.picLogout.Margin = new System.Windows.Forms.Padding(0);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(40, 40);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 0;
            this.picLogout.TabStop = false;
            // 
            // picPrevious
            // 
            this.picPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrevious.Image = global::HQT.Properties.Resources.previous;
            this.picPrevious.Location = new System.Drawing.Point(83, 0);
            this.picPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(40, 40);
            this.picPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrevious.TabIndex = 0;
            this.picPrevious.TabStop = false;
            // 
            // picNext
            // 
            this.picNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Image = global::HQT.Properties.Resources.next;
            this.picNext.Location = new System.Drawing.Point(527, 0);
            this.picNext.Margin = new System.Windows.Forms.Padding(0);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(40, 40);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 0;
            this.picNext.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HQT.Properties.Resources.account;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(246, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFullName.Enabled = false;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFullName.Location = new System.Drawing.Point(282, 13);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(161, 14);
            this.txtFullName.TabIndex = 2;
            // 
            // StatusBarUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPrevious);
            this.Controls.Add(this.picHome);
            this.Name = "StatusBarUserControl";
            this.Size = new System.Drawing.Size(650, 41);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFullName;
    }
}
