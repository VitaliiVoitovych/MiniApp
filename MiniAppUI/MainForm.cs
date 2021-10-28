using MiniAppBL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAppUI
{
    public partial class MainForm : Form
    {
        private MiniAppDbContext db;
        private Forms.MessageForm messageForm;
        public MainForm()
        {
            InitializeComponent();
            db = new MiniAppDbContext();
        }

        private void LoadTable<T>(DbSet<T> set, object sender) where T: class
        {
            Button button = sender as Button;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
            titleLbl.Text = button.Text;
        }

        private void ProviderBtn_Click(object sender, EventArgs e)
        {
            LoadTable(db.Provider, sender);
        }

        private void ComponentTypeBtn_Click(object sender, EventArgs e)
        {
            LoadTable(db.ComponentType, sender);
        }

        private void ComponentType_Click(object sender, EventArgs e)
        {
            LoadTable(db.Component, sender);
        }

        private void StorageBtn_Click(object sender, EventArgs e)
        {
            LoadTable(db.Storage, sender);
        }
        private void SaveAndUpdate()
        {
            db.SaveChanges();
            dataGridView.Update();
        }

        private void AddRecord<T>(DbSet<T> set, T entity) where T: class
        {
            set.Add(entity);
            SaveAndUpdate();
        }

        private void RemoveRecord<T>(DbSet<T> set, T entity) where T: class
        {
            set.Remove(entity);
            SaveAndUpdate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            switch (titleLbl.Text)
            {
                case "Постачальник":
                    var providerForm = new Forms.ProviderForm();
                    if (providerForm.ShowDialog() == DialogResult.OK)
                        AddRecord(db.Provider, providerForm.Provider);
                    break;
                case "Тип":
                    var typeForm = new Forms.TypeForm();
                    if (typeForm.ShowDialog() == DialogResult.OK)
                        AddRecord(db.ComponentType, typeForm.Type);
                    break;
                case "Компонент":
                    var compoenentForm = new Forms.ComponentForm();
                    if (compoenentForm.ShowDialog() == DialogResult.OK)
                        AddRecord(db.Component, compoenentForm.Component);
                    break;
                case "Склад":
                    var storageForm = new Forms.StorageForm();
                    if (storageForm.ShowDialog() == DialogResult.OK)
                        AddRecord(db.Storage, storageForm.Storage);
                    break;
                default:
                    messageForm = new Forms.MessageForm("Виберіть таблицю.", "Повідомлення");
                    messageForm.ShowDialog();
                    break;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
            switch (titleLbl.Text)
            {
                case "Постачальник":
                    var provider = db.Provider.Find(id);
                    var providerForm = new Forms.ProviderForm(provider);
                    if (providerForm.ShowDialog() == DialogResult.OK)
                        SaveAndUpdate();
                    break;
                case "Тип":
                    var type = db.ComponentType.Find(id);
                    var typeForm = new Forms.TypeForm(type);
                    if (typeForm.ShowDialog() == DialogResult.OK)
                        SaveAndUpdate();
                    break;
                case "Компонент":
                    var component = db.Component.Find(id);
                    var compoenentForm = new Forms.ComponentForm(component);
                    if (compoenentForm.ShowDialog() == DialogResult.OK)
                        SaveAndUpdate();
                    break;
                case "Склад":
                    var storage = db.Storage.Find(id);
                    var storageForm = new Forms.StorageForm(storage);
                    if (storageForm.ShowDialog() == DialogResult.OK)
                        SaveAndUpdate();
                    break;
                default:
                    messageForm = new Forms.MessageForm("Виберіть таблицю.", "Повідомлення");
                    messageForm.ShowDialog();
                    break;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
            switch (titleLbl.Text)
            {
                case "Постачальник":
                    var provider = db.Provider.Find(id);
                    RemoveRecord(db.Provider, provider);
                    break;
                case "Тип":
                    var type = db.ComponentType.Find(id);
                    RemoveRecord(db.ComponentType, type);
                    break;
                case "Компонент":
                    var component = db.Component.Find(id);
                    RemoveRecord(db.Component, component);
                    break;
                case "Склад":
                    var storage = db.Storage.Find(id);
                    RemoveRecord(db.Storage, storage);
                    break;
                default:
                    messageForm = new Forms.MessageForm("Виберіть таблицю.", "Повідомлення");
                    messageForm.ShowDialog();
                    break;
            }
        }
    }
}
