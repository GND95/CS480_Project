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
    public partial class linkShorteners : Form
    {
        public linkShorteners()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blockedWebsiteForm blockedSiteForm = new blockedWebsiteForm();
            blockedSiteForm.Show();
            this.Hide();
        }

        private void linkShorteners_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //keep unused background processes of this program from piling up
        }
    }
}
