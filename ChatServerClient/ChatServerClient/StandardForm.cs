using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServerClient
{
    public partial class StandardForm : Form
    {
        public StandardForm()
        {
            InitializeComponent();
        }

        private int clientCount = 0;

        private void btnClient_Click(object sender, EventArgs e)
        {
            clientCount++;
            Client client = new Client(clientCount);
            client.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
