﻿
namespace MiniAppUI.Forms
{
    partial class ComponentForm
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
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(337, 47);
            // 
            // titleLbl
            // 
            this.titleLbl.Size = new System.Drawing.Size(337, 47);
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.Location = new System.Drawing.Point(250, 305);
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 357);
            this.Name = "ComponentForm";
            this.Text = "ComponentForm";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}