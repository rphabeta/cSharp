using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TcpClient _client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            _client = new TcpClient();
            _client.Connect(IPAddress.Parse("127.0.0.1"), 8080);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream stream = _client.GetStream();

            string text = "안녕하세요.";
            var messageBuffer = Encoding.UTF8.GetBytes(text);
            stream.Write(messageBuffer);

            byte[] buffer = new byte[1024];
            int read = stream.Read(buffer, 0, buffer.Length);

            string message = Encoding.UTF8.GetString(buffer, 0, read);

            MessageBox.Show(message);
        }
    }
}
