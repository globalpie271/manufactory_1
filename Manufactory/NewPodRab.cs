﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manufactory
{
    public partial class NewPodRab : Form
    {
        Form parentForm;
        public NewPodRab(Form parentForm)
        {
            this.ControlBox = false;
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void NewPodRab_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hideForm(object sender, EventArgs e)
        {
            this.parentForm.Enabled = true;
            this.Hide();
        }
    }
}
