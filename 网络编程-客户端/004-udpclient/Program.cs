using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace _004_udpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udp对象
            UdpClient client = new UdpClient();
            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);//把字符串变成字节数组
                client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("192.168.2.103"), 7788));
            }
            client.Close();
            Console.ReadKey();
        }
    }
}
