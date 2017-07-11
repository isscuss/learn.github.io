using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace 聊天室_socket_tcp服务器端
{
    class Program
    {
        static List<Client> clientList = new List<Client>();

        public static void BroadcastMessage(string message)
        {
            var notConnectedList = new List<Client>();
            foreach (var client in clientList)
            {
                if (client.Connected)
                    client.SendMessage(message);
                else
                {
                    notConnectedList.Add(client);
                }
            }
            foreach (var temp in notConnectedList)
            {
                clientList.Remove(temp);
            }
 
        }
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.102"), 7788));

            tcpServer.Listen(100);
            Console.WriteLine("server running...");

            while (true)
            {
                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("a client is connect!!");
                Client client = new Client(clientSocket);//把与每个客户端进行通信的收发逻辑放到client类中进行处理
                clientList.Add(client);
            }
        }
    }
}
