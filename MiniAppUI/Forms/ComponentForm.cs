using MiniAppBL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniAppUI.Forms
{
    public partial class ComponentForm : Form
    {
        public MiniAppBL.Models.Component Component { get; set; }
        public ComponentForm(MiniAppBL.Models.Component component)
        {
            InitializeComponent();

            Component = component ?? new MiniAppBL.Models.Component();
            nameTextBox.Text = Component.Name;
            numericUpDown1.Value = Component.Price;
            numericUpDown2.Value = Component.ComponentTypeId;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Component = Component ?? new MiniAppBL.Models.Component();
            Component.Name = nameTextBox.Text;
            Component.Price = numericUpDown1.Value;
            Component.ComponentTypeId = Convert.ToInt32(numericUpDown2.Value);
            Close();
        }
    }
}
