using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ChatUp
{
    public partial class Server : Form
    {
        private static TcpListener server = new TcpListener(IPAddress.Any, 16969);
        private static bool isServerStarted = false;

        public Server()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            while (isServerStarted == false)
            {
                richTextBox1.AppendText("\nStarting server...");
                server.Start();
                isServerStarted = true;
                UpdateUI();
                Thread.Sleep(1000);
                richTextBox1.AppendText("\nWaiting for connection...");
            }
        }

        private void ConnectClient()
        {
            TcpClient client = server.AcceptTcpClient();
            int attempts = 0;
            while (!client.Connected)
            {
                try
                {
                    attempts++;
                    client = server.AcceptTcpClient();
                }
                catch (SocketException e)
                {
                    MessageBox.Show("Connection attempts: " + attempts + "\n" + e.Message);
                }
            }
            richTextBox1.AppendText("Client connected.");
        }

        private void Server_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Welcome administrator!");
        }

        private void UpdateUI()
        {
            richTextBox1.Update();
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
