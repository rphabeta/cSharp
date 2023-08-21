using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatClientAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient _client;

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            _client = new TcpClient();
            await _client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 8080);
            _ = HandleClient(_client);
        }

        private async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int read;

            while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, read);

                listBox1.Items.Add(message);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream stream = _client.GetStream();

            string text = textBox1.Text;
            for (int i = 0; i < 100; i++)
            {
                var messageBuffer = Encoding.UTF8.GetBytes(text);
                stream.Write(messageBuffer);
            }
        }
    }
}
