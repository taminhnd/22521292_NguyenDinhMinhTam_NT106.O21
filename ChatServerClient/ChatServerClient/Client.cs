using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ChatServerClient
{
    public partial class Client : Form
    {
        public Client(int count)
        {
            InitializeComponent();
            this.Text = "Client_" + count.ToString();
            client_name.Text = this.Text;

            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        IPEndPoint IP;
        Socket client;

        int bytelength = 0;
        byte[] storagedata = new byte[1024 * 5000];

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server !!!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

            SendMessage(this.Text + " đã tham gia kênh chat");
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    bytelength = client.Receive(data);
                    storagedata = data;

                    AddMessage();
                }
            }
            catch
            {
                Close();
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            if (client_name.Text.Trim() == this.Text)
                MessageBox.Show("Vui lòng nhập tên khác tên hiện tại !!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (client_name.Text.Trim() == "")
                MessageBox.Show("Vui lòng không để ô trống !!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SendMessage(this.Text + " đã đổi tên thành " + client_name.Text);
                this.Text = client_name.Text;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textChatBox.Text.Trim() != "")
            {
                SendMessage(this.Text + ": " + textChatBox.Text.Trim());
            }
            else MessageBox.Show("Vui lòng không để ô trống !!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddMessage()
        {
            byte[] bytes = storagedata;
            List<byte> newBytes = new List<byte>();

            for (int i = 0; i < bytelength; i++)
            {
                newBytes.Add(bytes[i]);
            }
            byte[] newBytesArray = newBytes.ToArray();

            string a = Encoding.UTF8.GetString(newBytesArray);

            var jsonSetting = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string text = JsonSerializer.Deserialize<string>(a, jsonSetting);

            listBox1.Items.Add(text);
        }

        private void SendMessage(string a)
        {
            var jsonSetting = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonstring = JsonSerializer.Serialize(a, jsonSetting);

            byte[] bytes = Encoding.UTF8.GetBytes(jsonstring);

            client.Send(bytes);
        }
    }
}
