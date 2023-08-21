using System.Drawing.Text;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServerAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private TcpListener _listener;

        private async void btnListen_Click(object sender, EventArgs e)
        {
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);    
            _listener.Start();  

            while (true)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                _ = HandleClient(client);
            }
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

                var messageBuffer = Encoding.UTF8.GetBytes($"Server : {message}");
                stream.Write(messageBuffer);
            }
        }
    }
}
