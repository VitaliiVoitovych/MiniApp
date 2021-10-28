
namespace MiniAppUI.Forms
{
    partial class TypeForm
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
            this.headerPanel.Size = new System.Drawing.Size(326, 47);
            // 
            // titleLbl
            // 
            this.titleLbl.Location = new System.Drawing.Point(137, 13);
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.Location = new System.Drawing.Point(239, 304);
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 356);
            this.Name = "TypeForm";
            this.Text = "TypeForm";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}