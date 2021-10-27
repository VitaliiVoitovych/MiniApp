using MiniAppBL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAppUI.Forms
{
    public partial class StorageForm : Form
    {
        public Storage Storage { get; set; }
        public StorageForm(Storage storage)
        {
            InitializeComponent();
            Storage = storage ?? new Storage();
            numericUpDown1.Value = Storage.ComponentId;
            numericUpDown2.Value = Storage.ProviderId;
            numericUpDown3.Value = Storage.Count;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Storage = Storage ?? new Storage();
            Storage.ComponentId = Convert.ToInt32(numericUpDown1.Value);
            Storage.ProviderId = Convert.ToInt32(numericUpDown2.Value);
            Storage.Count = Convert.ToInt32(numericUpDown3.Value);
            Close();
        }
    }
}
