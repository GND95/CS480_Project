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
    public partial class internetForm : Form
    {
        public internetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenuForm MM = new mainMenuForm();
            this.Hide();
            MM.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            blankWebpageForm blankSiteForm = new blankWebpageForm();
            blankSiteForm.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            blockedWebsiteForm blockedSiteForm = new blockedWebsiteForm();
            blockedSiteForm.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            noInternetForm noNetForm = new noInternetForm();
            noNetForm.Show();
            this.Hide();
        }
    }
}
