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
    public partial class Markers : Form
    {
        public Markers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smartBoardForm SBF = new smartBoardForm();
            SBF.Show();
            this.Hide();
        }
    }
}
