using MiniAppBL.Models;
using System;

namespace MiniAppUI.Forms
{
    public partial class ComponentForm : EntityBaseForm
    {
        public Component Component { get; set; }
        public ComponentForm()
        {
            InitializeComponent();
        }

        public ComponentForm(Component component) : this()
        {
            Component = component;
            nameTextBox.Text = Component.Name;
            priceNumericUpDown.Value = Component.Price;
            typeNumericUpDown.Value = Component.ComponentTypeId;

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Component = Component ?? new Component();
            Component.Name = nameTextBox.Text;
            Component.Price = priceNumericUpDown.Value;
            Component.ComponentTypeId = Convert.ToInt32(typeNumericUpDown.Value);
            Close();
        }
    }
}
