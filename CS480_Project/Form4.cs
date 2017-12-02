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
    public partial class smartBoardForm : Form
    {
        public smartBoardForm()
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
            Noninteractive NI = new Noninteractive();
            NI.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Markers mark = new Markers();
            mark.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Reorient re = new Reorient();
            re.Show();
            this.Hide();
        }

        private void smartBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //keep unused background processes of this program from piling up
        }
    }
}
