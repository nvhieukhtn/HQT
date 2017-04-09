namespace HQT
{
    partial class Practice
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
            this.btnTitle = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbPractice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPractice
            // 
            this.grbPractice.Controls.Add(this.btnTitle);
            this.grbPractice.Controls.Add(this.grbDetail);
            this.grbPractice.Controls.Add(this.label1);
            this.grbPractice.Location = new System.Drawing.Point(0, 0);
            this.grbPractice.Name = "grbPractice";
            this.grbPractice.Size = new System.Drawing.Size(660, 90);
            this.grbPractice.TabIndex = 0;
            this.grbPractice.TabStop = false;
            this.grbPractice.Text = "Đề bài";
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTitle.CausesValidation = false;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.Location = new System.Drawing.Point(80, 22);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(559, 23);
            this.btnTitle.TabIndex = 3;
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // grbDetail
            // 
            this.grbDetail.Location = new System.Drawing.Point(20, 50);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(611, 34);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            this.grbDetail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề : ";
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPractice);
            this.Name = "Practice";
            this.Size = new System.Drawing.Size(660, 90);
            this.grbPractice.ResumeLayout(false);
            this.grbPractice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPractice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Button btnTitle;
    }
}
