using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 使用FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件流，用来操作文件
            //FileStream stream = new FileStream("TextFile1.txt", FileMode.Open);//已存在的文件
            ////读取数据
            //byte[] data = new byte[1024];//创建数据容器
            //while (true)//利用while来循环利用数据容器，进而读取较大容量的数据
            //{
            //    int length = stream.Read(data, 0, data.Length);//如果读取的数据是末尾，返回值length为0
            //    if (length == 0)
            //    {
            //        Console.WriteLine("读取完毕");
            //        break;
            //    }
            //    for (int i = 0; i < length; i++)//利用for循环输出数据
            //    {
            //        Console.Write(data[i] + " ");
            //    }
            //}  
            //strea.Close();
            //Console.ReadKey();

            //使用filestream完成文件的复制(先读取，后新建一个文件写入数据)
            FileStream readStream = new FileStream("Different Heaven - OMG  NCS Release .mp3", FileMode.Open);//读取文件
            FileStream writeStream = new FileStream("newone.mp3", FileMode.Create);//新建文件
            byte[] data = new byte[1024];//创建一个数据容器
            while (true)
            {
                int length = readStream.Read(data, 0, data.Length);
                if (length == 0)
                {
                    Console.WriteLine("读取完毕");
                    break;
                }
                else
                {
                    writeStream.Write(data, 0, data.Length);//写入到新的流中
                }
            }
            //关闭流资源,done
            readStream.Close();
            writeStream.Close();
            Console.ReadKey();
        }
    }
}
