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
        public MainForm()
        {
            InitializeComponent();
            db = new MiniAppDbContext();
        }

        private void LoadTable<T>(DbSet<T> set, object sender) where T: class
        {
            Button button = sender as Button;
            titleLbl.Text = button.Text;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
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

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
