﻿using System;
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
    public partial class ProviderForm : EntityBaseForm
    {
        public ProviderForm()
        {
            InitializeComponent();
        }
        public ProviderForm(string titleText) : base(titleText)
        {
            InitializeComponent();
        }
    }
}