using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace 聊天室_socket_tcp服务器端
{
    class Program
    {
        static List<Client> clientList = new List<Client>();
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.237"), 7788));
            tcpServer.Listen(100);
            Console.WriteLine("服务器启动");
            while (true)
            {
                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("一个客户端连接成功！");
                Client client = new Client(clientSocket);//把与每个客户端连接的通信逻辑放到Client类中处理
                clientList.Add(client);
            }
        }
    }
}
