using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace 聊天室_socket_tcp服务器端
{   //用来跟客户端做通信
    class Client
    {
        private Socket clientSocket;
        private Thread t;
        private byte[] data = new byte[1024];//接受客户端发送过来的容器
        public Client(Socket s)
        {
            clientSocket = s;
            t = new Thread(ReceiveMessage);
            t.Start();
          
        }
        private void ReceiveMessage()
        {
            //接收客户端传过来的数据
            while (true) 
            {
                //判断socket是否断开连接
                if (clientSocket.Poll(10, SelectMode.SelectRead))
                {
                    clientSocket.Close();
                    break;//终止线程的执行
                }
                int length=clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data, 0, length);
                Program.BroadcastMessage(message);
                Console.WriteLine("收到的消息:" + message);

            }
        }
        public void SendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
        }
        public bool Connected
        {
            get { return clientSocket.Connected; }
        }
    }
}
