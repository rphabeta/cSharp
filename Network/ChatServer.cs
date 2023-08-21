using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 이와 같이 처리할 경우 동기적으로 처리하여, 메인스레드가 블로킹이된 상태로 대기하여야하는 문제가 존재. 비동기적으로 문제 처리 필요
        private TcpListener _listener;

        private void btnListen_Click(object sender, EventArgs e)
        {
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            _listener.Start(); // 서버 실행

            // 클라이언트가 저 ip, port로 접근할때까지 대기
            // 따라서 main thread blocking
            TcpClient client = _listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream(); // 해당 스트림을 통해서 데이터를 주고 받을 수 있게 됨.
            
            byte[] buffer = new byte[1024];
            int read = stream.Read(buffer, 0, buffer.Length);  // 버퍼의 선언된 크기보다 읽어들인 크기가 작을 것을 알고 있고, 그걸 위해서 읽어들인 크기를 반환 값으로 받을 수 있다.
                                                                // 추가로 클라이언트에서 메세지를 주기 전까지 대기.
            // 그리고 읽어들인 버퍼를 text로 바꾸기 위해서 encoding 과정을 거침
            string message = Encoding.UTF8.GetString(buffer, 0, read);
            MessageBox.Show(message);


            var messageBuffer = Encoding.UTF8.GetBytes($"Server: {message}");
            stream.Write(messageBuffer);
        }
    }
}
