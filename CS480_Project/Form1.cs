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
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            interneForm netForm = new interneForm();
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
            MailMessage email = new MailMessage("gdcs480project@gmail.com", "garrettdeblois13@yahoo.com", "Support", emailBody.Text.ToString()); //originating email address, target email address, email subject field, email body field
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            NetworkCredential nc = new NetworkCredential("gdcs480project@gmail.com", "randomp455w0rd123!"); //username and password to the account that the emails originate from
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(email); //code to send the email, if it is successful, the message directly below is displayed, else the catch statement goes into effect and that code is executed
                MessageBox.Show("Email sent successfully.", "Success");
            }
            catch (System.Net.Mail.SmtpException)
            {
                MessageBox.Show("Email could not be sent. Please call technology or submit a support ticket.", "Error");
            }
        }
    }
}
