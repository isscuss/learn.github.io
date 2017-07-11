using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace _002_udp协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建socket
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            while (true)//可循环发送数据了
            {
                //发送数据
                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("10.101.117.210"), 7788);
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.SendTo(data, serverPoint);
            }
           
           
            udpClient.Close();
            Console.ReadKey();
        }
    }
}
