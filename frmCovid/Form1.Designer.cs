﻿
namespace frmCovid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJan = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJan
            // 
            this.btnJan.Location = new System.Drawing.Point(352, 245);
            this.btnJan.Name = "btnJan";
            this.btnJan.Size = new System.Drawing.Size(75, 23);
            this.btnJan.TabIndex = 0;
            this.btnJan.Text = "Jan Clicked covid";
            this.btnJan.UseVisualStyleBackColor = true;
            this.btnJan.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(334, 155);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 23);
            this.txtInput.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(297, 338);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 15);
            this.lblOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnJan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJan;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
    }
}

