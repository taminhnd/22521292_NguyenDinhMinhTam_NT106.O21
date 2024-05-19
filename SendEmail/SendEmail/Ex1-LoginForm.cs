using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SendEmail
{
    public partial class Ex1_LoginForm : Form
    {
        public Ex1_LoginForm()
        {
            InitializeComponent();
        }
        SmtpClient smtpclient;
        string smtp_pass = "jhyncclcmqriubui";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            smtpclient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(txtUser.Text, txtPass.Text),
                EnableSsl = true
            };
            SendEmail.Ex1 ex1 = new Ex1(smtpclient, txtUser.Text);
            ex1.ShowDialog();
            this.Close();
        }
    }
}
