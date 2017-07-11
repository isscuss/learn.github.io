using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Socket编程_tcp协议_服务器端
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建socket
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //绑定ip跟端口号192.168.2.156
            IPAddress ipaddress = new IPAddress(new byte[] { 192, 168, 2, 156 });
            EndPoint point = new IPEndPoint(ipaddress, 7788);
            //向操作系统申请一个可用ip跟端口号，用来通信
            tcpServer.Bind(point);
            //开始监听
            tcpServer.Listen(100);
            Console.WriteLine("开始监听");
            Socket clientSocket=tcpServer.Accept();//暂停当前线程，等待客户端连接过来，再进行以下操作
            Console.WriteLine("一个客户端连接过来了");
            //使用返回的socket跟客户端通信
            string message = "hello 欢迎你";
            byte[] data = Encoding.UTF8.GetBytes(message);//对字符串进行编码，变成字符数组
            clientSocket.Send(data);
            Console.WriteLine("向客户端发送一条数据");

            //接收从客户端发送过来的数据
            byte[] data2 = new byte[1024];//创建一个字节数组当做容器，去承接客户端发送过来的消息
            int length = clientSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);//把字节数组转换成字符串
            Console.WriteLine("接收到一个从客户端发送过来的消息：" + message2);
            Console.ReadKey();
        }
    }
}
