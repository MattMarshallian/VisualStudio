﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            // Show a congratulatory MessageBox, then close the form.
            MessageBox.Show("Congratulations!");
            Close();
        }
    }
}