﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS480_Project
{
    public partial class blockedWebsiteForm : Form
    {
        public blockedWebsiteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            internetForm netForm = new internetForm();
            netForm.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            categorizedWebsite CW = new categorizedWebsite();
            CW.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            linkShorteners LS = new linkShorteners();
            LS.Show();
            this.Hide();
        }

        private void blockedWebsiteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //keep unused background processes of this program from piling up
        }
    }
}
