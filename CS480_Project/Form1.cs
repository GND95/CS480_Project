using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //for networkcredential part of email code
using System.Net.Mail; //for email capabilities
using System.Text.RegularExpressions; //use regex to format and remove certain text from email body

namespace CS480_Project
{
    public partial class mainMenuForm : Form
    {
        bool emailClicked = false; //used to clear the text in the email section the first time the user clicks here  
        bool nameClicked = false; //used to clear the text in the name section the first time the user clicks here

        public mainMenuForm()
        {
            InitializeComponent();            
            comboBox2.Items.AddRange(new string[] { "1 (Least Urgent)", "2 (Low Urgency)", "3 (Medium Urgency)", "4 (High Urgency)", "5 (Most Urgent)" });
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            internetForm netForm = new internetForm();
            netForm.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            printerForm printerForm = new printerForm();
            printerForm.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            smartBoardForm smartBoardForm = new smartBoardForm();
            smartBoardForm.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            soundForm soundForm = new soundForm();
            soundForm.Show();
            this.Hide();
        }

        private void mailButton_Click(object sender, EventArgs e) //code to make the email section work
        {
            string emailSubject = nameBox.Text; //use this to get the teacher name so that it will be included in the subject field of the email  
            string emailPriorityLevel = this.comboBox2.GetItemText(this.comboBox2.SelectedItem); //use this to get the priority level to include in the email subject
            MailMessage email = new MailMessage("gdcs480project@gmail.com", "garrettdeblois13@yahoo.com", "Support, " + "Priority level: " + emailPriorityLevel + ", " + emailSubject, emailBody.Text.ToString()); //originating email address, target email address, email subject field, email body field
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            NetworkCredential nc = new NetworkCredential("gdcs480project@gmail.com", "randomp455w0rd123!"); //username and password to the account that the emails originate from
            smtp.Credentials = nc;
            smtp.EnableSsl = true;

            if (emailBody.Text == "Describe your issue here" || emailBody.Text == "")
            {
                MessageBox.Show("Please describe your issue.", "Error");
            }
            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a priority level.", "Error");
            }
            else if (nameBox.Text == "" || nameBox.Text == "Please enter your name")
            {
               MessageBox.Show("Please enter your name.", "Error");
            }
            else
            {
                try
                {
                    mailButton.Enabled = false; //prevent the user from sending multiple messages
                    smtp.Send(email); //code to send the email, if it is successful, the message directly below is displayed, else the catch statement goes into effect and that code is executed
                    MessageBox.Show("Email sent successfully.", "Success");
                    mailButton.Enabled = true;
                }
                catch (System.Net.Mail.SmtpException)
                {
                    MessageBox.Show("Email could not be sent. Please call or email technology.", "Error");
                }
            }
        }

        private void emailBody_Click(object sender, EventArgs e)
        {
            if (emailClicked == false) //prevent multiple clicks in the email text section from reseting the text
            {
                emailBody.Text = "";
            }
            emailClicked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            StaffDirectory directory = new StaffDirectory();
            directory.Show();
            this.Hide();
        }

        private void mainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //keep unused background processes of this program from piling up
        }

        private void nameBox_Click(object sender, EventArgs e)
        {
            if (nameClicked == false) //prevent multiple clicks in the email text section from reseting the text
            {
                nameBox.Text = "";
            }
            nameClicked = true;
        }
    }
}
