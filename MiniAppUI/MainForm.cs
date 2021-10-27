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
        private bool isLoaded = false;
        public MainForm()
        {
            InitializeComponent();
            db = new MiniAppDbContext();
            Task.Run(() =>
            {
                db.Provider.Load();
                isLoaded = true;
            });
        }

        private void LoadTable<T>(DbSet<T> set) where T: class
        {
            if (isLoaded)
            {
                set.Load();
                dataGridView.DataSource = set.Local.ToBindingList();
            }
        }

        private void ProviderBtn_Click(object sender, EventArgs e)
        {
            LoadTable(db.Provider);
        }

        private void ComponentTypeBtn_Click(object sender, EventArgs e)
        {
            LoadTable(db.ComponentType);
        }

        private void ComponentType_Click(object sender, EventArgs e)
        {
            LoadTable(db.Component);
        }

        private void StorageBtn_Click(object sender, EventArgs e)
        {
            LoadTable(db.Storage);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
