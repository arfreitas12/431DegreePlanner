﻿namespace DegreePlanner
{
    partial class scheduleCheckOutput
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
            this.button1 = new System.Windows.Forms.Button();
            this.validityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeWindow);
            // 
            // validityLabel
            // 
            this.validityLabel.AutoSize = true;
            this.validityLabel.Location = new System.Drawing.Point(30, 20);
            this.validityLabel.MaximumSize = new System.Drawing.Size(300, 13);
            this.validityLabel.Name = "validityLabel";
            this.validityLabel.Size = new System.Drawing.Size(35, 13);
            this.validityLabel.TabIndex = 1;
            this.validityLabel.Text = "label1";
            // 
            // scheduleCheckOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 132);
            this.Controls.Add(this.validityLabel);
            this.Controls.Add(this.button1);
            this.Name = "scheduleCheckOutput";
            this.Text = "scheduleCheckOutput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label validityLabel;
    }
}