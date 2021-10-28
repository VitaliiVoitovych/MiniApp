using MiniAppBL.Models;
using System;

namespace MiniAppUI.Forms
{
    public partial class TypeForm : EntityBaseForm
    {
        public ComponentType Type { get; set; }
        public TypeForm()
        {
            InitializeComponent();
        }

        public TypeForm(ComponentType type) : this()
        {
            Type = type;
            nameTextBox.Text = Type.Name;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Type = Type ?? new ComponentType();
            Type.Name = nameTextBox.Text;
            Close();
        }
    }
}
