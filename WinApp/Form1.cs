﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            clickButton.Click += ClickResponder;
        }

        public void ClickResponder(object sender, EventArgs args)
        {
        }
    }
}
