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
    public partial class StorageForm : EntityBaseForm
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        public StorageForm(string titleText) : base(titleText)
        {
            InitializeComponent();
        }
    }
}
