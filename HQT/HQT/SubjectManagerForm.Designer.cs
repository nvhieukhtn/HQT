﻿namespace HQT
{
    partial class SubjectManagerForm
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
            this.subjectFilter = new HQT.SubjectFilterUserControl();
            this.SuspendLayout();
            // 
            // subjectFilter
            // 
            this.subjectFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectFilter.Location = new System.Drawing.Point(12, 53);
            this.subjectFilter.Name = "subjectFilter";
            this.subjectFilter.Size = new System.Drawing.Size(642, 30);
            this.subjectFilter.TabIndex = 1;
            // 
            // SubjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.subjectFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SubjectManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectManager_FormClosing);
            this.Load += new System.EventHandler(this.SubjectManager_Load);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.subjectFilter, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private SubjectFilterUserControl subjectFilter;
    }
}