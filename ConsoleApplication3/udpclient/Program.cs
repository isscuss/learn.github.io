using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace udpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建uodpclient，绑定ip跟端口号
            UdpClient udpclient = new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.2.103"), 7788));
            while (true)
            {
                //接收数据
                IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);//通过point确定数据来源的ip跟端口号
                byte[] data = udpclient.Receive(ref point);
                string message = Encoding.UTF8.GetString(data);//把字节数组转变成字符串
                Console.WriteLine("收到的消息是：" + message);
            }
            udpclient.Close();
            Console.ReadKey();
        }
    }
}
