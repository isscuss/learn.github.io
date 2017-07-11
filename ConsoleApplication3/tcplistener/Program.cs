using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace tcplistener
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.tcplistener是对sockets作了一层封装，在该类中，会自己去创建socket对象
            TcpListener listener=new TcpListener(IPAddress.Parse("192.168.2.103"),7788);
            //2.开始监听
            listener.Start();
            //3.等待客户端连接过来
            TcpClient client = listener.AcceptTcpClient();
            //4.取得客户端发过来的数据
            NetworkStream stream= client.GetStream();//得到一个网络流
            byte[] data = new byte[1024];//创建一个存储数据的容器,大小为1024字节
            while (true)
            {
                int length = stream.Read(data, 0, 1024);//读取数据，虽然这是只有一次的情况
                string message = Encoding.UTF8.GetString(data, 0, length);//把数据流转变成字符串输出
                Console.WriteLine("收到的消息是：" + message);
            }
            //释放资源：网络流，客户端，监听器
            stream.Close();
            client.Close();
            listener.Stop();
            Console.ReadKey();
        }
    }
}
