using MiniAppBL.Models;
using System;

namespace MiniAppUI.Forms
{
    public partial class ProviderForm : EntityBaseForm
    {
        public Provider Provider { get; set; }
        public ProviderForm()
        {
            InitializeComponent();
        }

        public ProviderForm(Provider provider) : this()
        {
            Provider = provider;
            nameTextBox.Text = Provider.Name;
            addressTextBox.Text = Provider.Address;
            phoneTextBox.Text = Provider.Phone;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Provider = Provider ?? new Provider();
            Provider.Name = nameTextBox.Text;
            Provider.Address = addressTextBox.Text;
            Provider.Phone = phoneTextBox.Text;
            Close();
        }
    }
}
