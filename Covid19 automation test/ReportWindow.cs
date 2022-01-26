using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;    
using System.Net.Mail;

namespace Covid19_automation_test
{
    public partial class ReportWindow : Form
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reportMessage = textBox1.Text;

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("testingemailcompproj@gmail.com");
            mail.To.Add("gogo170109@gmail.com");
            mail.Subject = "Bug report";
            mail.Body = reportMessage;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("testingemailcompproj@gmail.com", "ComputerTesting");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            MessageBox.Show("Съобщението изпратено!");
            this.Close();
        }
    }
}
