namespace HQT
{
    partial class StatusBar
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
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
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
            this.picNext.Image = global::HQT.Properties.Resources.next;
            this.picNext.Location = new System.Drawing.Point(527, 0);
            this.picNext.Margin = new System.Windows.Forms.Padding(0);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(40, 40);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 0;
            this.picNext.TabStop = false;
            // 
            // StatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPrevious);
            this.Controls.Add(this.picHome);
            this.Name = "StatusBar";
            this.Size = new System.Drawing.Size(650, 41);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.PictureBox picNext;
    }
}
