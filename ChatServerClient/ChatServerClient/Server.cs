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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Encodings.Web;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ChatServerClient
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList = new List<Socket>();

        int bytelength = 0;
        byte[] storagedata = new byte[1024 * 5000];

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int count = 0;

            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(1000);
                        Socket client = server.Accept();

                        clientList.Add(client);
                        count++;

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        void Receive(object obj)
        {
            Socket c = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    bytelength = c.Receive(data);
                    storagedata = data;

                    AddMessage();
                }
            }
            catch
            {
                clientList.Remove(c);
                c.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textChatBox.Text != "")
            {
                SendMessage("Server: " + textChatBox.Text);
                listBox1.Items.Add(textChatBox.Text);
                textChatBox.Clear();
            }
            else MessageBox.Show("Vui lòng không để ô trống !!!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
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
            string message = JsonSerializer.Deserialize<string>(a, jsonSetting);

            listBox1.Items.Add(message);
            SendMessage(message);
        }

        private void SendMessage(string a)
        {
            var jsonSetting = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonstring = JsonSerializer.Serialize(a, jsonSetting);

            byte[] bytes = Encoding.UTF8.GetBytes(jsonstring);

            foreach (Socket item in clientList)
            {
                item.Send(bytes);
            }
        }
    }
}
