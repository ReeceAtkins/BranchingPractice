﻿namespace BranchingPractice
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
            btnDisplay = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(172, 230);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(172, 56);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display user greeting";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Branching Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplay;
        private TextBox txtName;
    }
}