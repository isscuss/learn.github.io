using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Socke编程_tcp协议_服务器端
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //绑定ip跟端口，ip为192.168.24.4
            IPAddress ipaddress=new IPAddress(new byte[]{192,168,1,237});
            EndPoint point = new IPEndPoint(ipaddress, 7788);//IPEndPoint是对ip和端口封装的一个类
            tcpServer.Bind(point); //向系统申请ip跟端口用作通信
            //监听和定义最大连接数
            tcpServer.Listen(100);
            Console.WriteLine("开始监听");
            Socket clientSocker = tcpServer.Accept();//暂停线程，等接收到客户端信息才继续往下走
            Console.WriteLine("客户端连接过来啦！");
            string message = "hello 欢迎";
            byte[] data = Encoding.UTF8.GetBytes(message);//对字符编码，得到一个字节数组
            clientSocker.Send(data);
            Console.WriteLine("向客户端发送一段数据");
            byte[] data2 = new byte[1024];// 创建字节数组当容器，承接客户端传过来的数据
            int length = clientSocker.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, length);
            Console.WriteLine("接收到一个从客户端发过来的消息：" + message2);
            Console.ReadKey();
        }
    }
}
