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
        bool clicked = false; //used to clear the text in the email section the first time the user clicks here       

        public mainMenuForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Cathryn Firmin", "Kassy Forrest", "Leon Foster", "Peggy Giles", "Shauna Hext", "Jasmine Kimball", "Karissa Peyton", "Sherie Sayer", "Darcey Walters", "Aggie Whittle" }); //random names created by an online random name generator
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
            string emailSubject = this.comboBox1.GetItemText(this.comboBox1.SelectedItem); //use this to get the teacher name so that it will be included in the subject field of the email          
            MailMessage email = new MailMessage("gdcs480project@gmail.com", "garrettdeblois13@yahoo.com", "Support, " +emailSubject, emailBody.Text.ToString()); //originating email address, target email address, email subject field, email body field
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            NetworkCredential nc = new NetworkCredential("gdcs480project@gmail.com", "randomp455w0rd123!"); //username and password to the account that the emails originate from
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select your name.", "Error");
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
                    MessageBox.Show("Email could not be sent. Please call technology or submit a support ticket.", "Error");
                }
            }
        }

        private void emailBody_Click(object sender, EventArgs e)
        {
            if (clicked == false) //prevent multiple clicks in the email text section from reseting the text
            {
                emailBody.Text = "";
            }
            clicked = true;
        }
    }
}
