
namespace MiniAppUI.Forms
{
    partial class StorageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.providerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.componentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Size = new System.Drawing.Size(254, 47);
            // 
            // titleLbl
            // 
            this.titleLbl.Size = new System.Drawing.Size(254, 47);
            this.titleLbl.Text = "Склад";
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.Location = new System.Drawing.Point(167, 209);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Компонент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Постачальник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кількість";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.countNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNumericUpDown.Location = new System.Drawing.Point(149, 144);
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(91, 26);
            this.countNumericUpDown.TabIndex = 5;
            // 
            // providerNumericUpDown
            // 
            this.providerNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.providerNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.providerNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerNumericUpDown.Location = new System.Drawing.Point(149, 106);
            this.providerNumericUpDown.Name = "providerNumericUpDown";
            this.providerNumericUpDown.Size = new System.Drawing.Size(91, 26);
            this.providerNumericUpDown.TabIndex = 6;
            // 
            // componentNumericUpDown
            // 
            this.componentNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.componentNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentNumericUpDown.Location = new System.Drawing.Point(149, 68);
            this.componentNumericUpDown.Name = "componentNumericUpDown";
            this.componentNumericUpDown.Size = new System.Drawing.Size(91, 26);
            this.componentNumericUpDown.TabIndex = 7;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.componentNumericUpDown);
            this.Controls.Add(this.providerNumericUpDown);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Controls.SetChildIndex(this.headerPanel, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.countNumericUpDown, 0);
            this.Controls.SetChildIndex(this.providerNumericUpDown, 0);
            this.Controls.SetChildIndex(this.componentNumericUpDown, 0);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.NumericUpDown providerNumericUpDown;
        private System.Windows.Forms.NumericUpDown componentNumericUpDown;
    }
}