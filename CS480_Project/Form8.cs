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
    public partial class blankWebpageForm : Form
    {
        public blankWebpageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            internetForm netForm = new internetForm();
            netForm.Show();
            this.Hide();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText); //event to make the hyperlink work
        }

        private void blankWebpageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //keep unused background processes of this program from piling up
        }
    }
}
