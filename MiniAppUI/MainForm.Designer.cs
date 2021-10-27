
namespace MiniAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.storageBtn = new System.Windows.Forms.Button();
            this.componentType = new System.Windows.Forms.Button();
            this.componentTypeBtn = new System.Windows.Forms.Button();
            this.providerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(90)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.storageBtn);
            this.panelMenu.Controls.Add(this.componentType);
            this.panelMenu.Controls.Add(this.componentTypeBtn);
            this.panelMenu.Controls.Add(this.providerBtn);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(156, 452);
            this.panelMenu.TabIndex = 0;
            // 
            // storageBtn
            // 
            this.storageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.storageBtn.FlatAppearance.BorderSize = 0;
            this.storageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.storageBtn.Image = ((System.Drawing.Image)(resources.GetObject("storageBtn.Image")));
            this.storageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storageBtn.Location = new System.Drawing.Point(0, 176);
            this.storageBtn.Name = "storageBtn";
            this.storageBtn.Size = new System.Drawing.Size(156, 42);
            this.storageBtn.TabIndex = 4;
            this.storageBtn.Text = "Склад";
            this.storageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.storageBtn.UseVisualStyleBackColor = true;
            this.storageBtn.Click += new System.EventHandler(this.StorageBtn_Click);
            // 
            // componentType
            // 
            this.componentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.componentType.FlatAppearance.BorderSize = 0;
            this.componentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.componentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.componentType.Image = ((System.Drawing.Image)(resources.GetObject("componentType.Image")));
            this.componentType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.componentType.Location = new System.Drawing.Point(0, 134);
            this.componentType.Name = "componentType";
            this.componentType.Size = new System.Drawing.Size(156, 42);
            this.componentType.TabIndex = 3;
            this.componentType.Text = "Компонент";
            this.componentType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.componentType.UseVisualStyleBackColor = true;
            this.componentType.Click += new System.EventHandler(this.ComponentType_Click);
            // 
            // componentTypeBtn
            // 
            this.componentTypeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.componentTypeBtn.FlatAppearance.BorderSize = 0;
            this.componentTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.componentTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.componentTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.componentTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("componentTypeBtn.Image")));
            this.componentTypeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.componentTypeBtn.Location = new System.Drawing.Point(0, 92);
            this.componentTypeBtn.Name = "componentTypeBtn";
            this.componentTypeBtn.Size = new System.Drawing.Size(156, 42);
            this.componentTypeBtn.TabIndex = 2;
            this.componentTypeBtn.Text = "Тип";
            this.componentTypeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.componentTypeBtn.UseVisualStyleBackColor = true;
            this.componentTypeBtn.Click += new System.EventHandler(this.ComponentTypeBtn_Click);
            // 
            // providerBtn
            // 
            this.providerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.providerBtn.FlatAppearance.BorderSize = 0;
            this.providerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.providerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.providerBtn.Image = ((System.Drawing.Image)(resources.GetObject("providerBtn.Image")));
            this.providerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.providerBtn.Location = new System.Drawing.Point(0, 50);
            this.providerBtn.Name = "providerBtn";
            this.providerBtn.Size = new System.Drawing.Size(156, 42);
            this.providerBtn.TabIndex = 1;
            this.providerBtn.Text = "Постачальник";
            this.providerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.providerBtn.UseVisualStyleBackColor = true;
            this.providerBtn.Click += new System.EventHandler(this.ProviderBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 50);
            this.panel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(90)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.titleLbl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(156, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(708, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.titleLbl.Location = new System.Drawing.Point(6, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(167, 31);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "База даних";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(162, 56);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(690, 341);
            this.dataGridView.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(582, 403);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(86, 37);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Додати";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(674, 403);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(86, 37);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Редагувати";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(766, 403);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(86, 37);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Видалити";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(864, 452);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(880, 490);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button storageBtn;
        private System.Windows.Forms.Button componentType;
        private System.Windows.Forms.Button componentTypeBtn;
        private System.Windows.Forms.Button providerBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}