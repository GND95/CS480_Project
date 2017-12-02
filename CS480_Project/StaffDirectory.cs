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
    public partial class StaffDirectory : Form
    {
        public StaffDirectory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenuForm MM = new mainMenuForm();
            this.Hide();
            MM.Show();
        }

        private void StaffDirectory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Employees' table.
            this.employeesTableAdapter.Fill(this.appData.Employees);
            employeesBindingSource.DataSource = this.appData.Employees;
            dataGridView1.ReadOnly = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ReadOnly = false; //whether or not you can edit the database information from the program
                this.appData.Employees.AddEmployeesRow(this.appData.Employees.NewEmployeesRow());
                employeesBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            employeesBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(this.appData.Employees);
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView1.DataSource = employeesBindingSource;
                }
                else
                {
                    var query = from o in this.appData.Employees
                                where o.FirstName.ToLower().Contains(txtSearch.Text.ToLower()) || o.LastName.ToLower().Contains(txtSearch.Text.ToLower()) || o.Building.ToLower().Contains(txtSearch.Text.ToLower()) || o.Location.ToLower().Contains(txtSearch.Text.ToLower()) || o.PhoneExtension.Contains(txtSearch.Text) //to lower to make this query case-insensitive
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    employeesBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dataGridView1.DataSource = employeesBindingSource;
            }
            else
            {
                var query = from o in this.appData.Employees
                            where o.FirstName.ToLower().Contains(txtSearch.Text.ToLower()) || o.LastName.ToLower().Contains(txtSearch.Text.ToLower()) || o.Building.ToLower().Contains(txtSearch.Text.ToLower()) || o.Location.ToLower().Contains(txtSearch.Text.ToLower()) || o.PhoneExtension.Contains(txtSearch.Text) //to lower to make this query case-insensitive
                            select o;
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void StaffDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //keep unused background processes of this program from piling up
        }
    }
}
