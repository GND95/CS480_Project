using System;
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
    public partial class categorizedWebsite : Form
    {
        public categorizedWebsite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blockedWebsiteForm blockedSiteForm = new blockedWebsiteForm();
            blockedSiteForm.Show();
            this.Hide();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText); //event to make the hyperlink work
        }
    }
}
