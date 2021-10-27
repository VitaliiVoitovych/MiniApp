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
    public partial class ProviderForm : Form
    {
        public Provider Provider { get; set; }
        public ProviderForm(Provider provider)
        {
            InitializeComponent();

            Provider = provider ?? new Provider();
            nameTextBox.Text = Provider.Name;
            addressTextBox.Text = Provider.Address;
            phoneTextBox.Text = Provider.Phone;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Provider = Provider ?? new Provider();
            Provider.Name = nameTextBox.Text;
            Provider.Address = addressTextBox.Text;
            Provider.Phone = phoneTextBox.Text;
            Close();
        }
    }
}
