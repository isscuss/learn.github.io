using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace _001_Socket编程_tcp协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建socket
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //发起建立连接的请求
            IPAddress ipaddress = IPAddress.Parse("192.168.2.107");//可以把字符串数字直接转换为ipaddress
            EndPoint point = new IPEndPoint(ipaddress, 7788);
            tcpClient.Connect(point);//通过ip和端口号定位一个要连接到的服务器端
            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);//length返回值表示接收了多少字节的数据
            string message = Encoding.UTF8.GetString(data, 0, length);//只把接收到的数据进行转换
            Console.WriteLine(message);
            //向服务器端发送消息
            string message2 = Console.ReadLine();
            tcpClient.Send(Encoding.UTF8.GetBytes(message2));//把字符串转化成字节数组，然后发送到服务器端
            Console.ReadKey();
        }
    }
}
