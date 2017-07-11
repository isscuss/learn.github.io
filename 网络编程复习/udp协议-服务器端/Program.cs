using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace udp协议_服务器端
{
    class Program
    {
        private static Socket udpServer;//定义成一个静态socket
        static void Main(string[] args)
        {
            //创建socket
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //绑定ip跟端口号
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("10.101.117.210"), 7788));
            //通过线程接收数据
            new Thread(ReceiveMessage) { IsBackground = true }.Start();//后台运行线程
            //udpServer.Close();
            Console.ReadKey();
        }
        static void ReceiveMessage()
        {
            while (true)//可循环接收数据了=。=
            {
                //接收数据
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = new byte[1024];
                int length = udpServer.ReceiveFrom(data, ref remoteEndPoint);//数据来源放到第二个参数中
                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("从ip：" + (remoteEndPoint as IPEndPoint).Address.ToString() + ":" + (remoteEndPoint as IPEndPoint).Port + "收到的数据：" + message);
            }

        }
    }
}
