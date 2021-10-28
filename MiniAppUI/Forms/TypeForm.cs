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
    public partial class TypeForm : EntityBaseForm
    {
        public TypeForm()
        {
            InitializeComponent();
        }

        public TypeForm(string titleText) : base(titleText)
        {
            InitializeComponent();
        }

    }
}
