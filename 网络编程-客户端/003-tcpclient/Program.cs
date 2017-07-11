using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace _003_tcpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建客户端：
            TcpClient client = new TcpClient("192.168.2.103", 7788);
            //通过网络流进行数据的交换
            NetworkStream stream = client.GetStream();
            while (true)
            {

                //write用来写入和发送数据
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);//把输入的字符变成数据流
                stream.Write(data, 0, data.Length);
            }
  
            //释放资源
            stream.Close();
            client.Close();
            Console.ReadKey();
        }
    }
}
