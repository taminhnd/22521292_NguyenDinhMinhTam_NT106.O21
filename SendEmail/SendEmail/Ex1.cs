using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmail
{
    public partial class Ex1 : Form
    {
        public Ex1(System.Net.Mail.SmtpClient smtpclient, string user)
        {
            InitializeComponent();
            this.smtpclient = smtpclient;
            txtFrom.Text = user;
        }
        System.Net.Mail.SmtpClient smtpclient;
        string smtp_pass = "gtrvscvbmeteywod";
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailAddress from = new System.Net.Mail.MailAddress(txtFrom.Text, "22521292-NguyenDinhMinhTam");
            System.Net.Mail.MailAddress to = new System.Net.Mail.MailAddress(txtTo.Text);
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage()
            {
                From = from,
                Subject = txtSubject.Text,
                Body = rtbBody.Text
            };

            mailMessage.To.Add(to);

            try
            {
                smtpclient.Send(mailMessage);
                MessageBox.Show("Email đã được gửi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
