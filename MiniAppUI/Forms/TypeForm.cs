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
    public partial class TypeForm : Form
    {
        public ComponentType ComponentType { get; set; }
        public TypeForm(ComponentType componentType)
        {
            InitializeComponent();

            ComponentType = componentType ?? new ComponentType();
            textBox1.Text = ComponentType.Name;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ComponentType = ComponentType ?? new ComponentType();
            ComponentType.Name = textBox1.Text;
            Close();
        }
    }
}
