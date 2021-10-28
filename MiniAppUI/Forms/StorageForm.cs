using MiniAppBL.Models;
using System;

namespace MiniAppUI.Forms
{
    public partial class StorageForm : EntityBaseForm
    {
        public Storage Storage { get; set; }
        public StorageForm()
        {
            InitializeComponent();
        }

        public StorageForm(Storage storage) : this()
        {
            Storage = storage;
            componentNumericUpDown.Value = Storage.ComponentId;
            providerNumericUpDown.Value = Storage.ProviderId;
            countNumericUpDown.Value = Storage.Count;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Storage = new Storage()
            {
                ComponentId = Convert.ToInt32(componentNumericUpDown.Value),
                ProviderId = Convert.ToInt32(providerNumericUpDown.Value),
                Count = Convert.ToInt32(countNumericUpDown.Value)
            };
            Close();
        }
    }
}
