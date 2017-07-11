using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 使用StreamReader和StreamWriter读写文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文本读取流
            StreamReader reader = new StreamReader("TextFile1.txt");

            //while这种东西挺重要的
            //方法1
            //while (true)
            //{
            //    string str = reader.ReadLine();//只读取一行
            //    if (str == null) break;//如果读取到末行，则退出
            //    Console.WriteLine(str);
            //}
            //Console.ReadKey();

            //方法2
            //string str = reader.ReadToEnd();//读取到文本的末尾
            //Console.WriteLine(str);
            //Console.ReadKey();

            //方法3 读取单个字符和while配合
            //while (true)
            //{
            //    int res = reader.Read();//只读取单个字符，而且返回int类型数据，若读取为空，则返回-1
            //    if (res == -1) break;
            //    else 
            //    {
            //        Console.Write((char)res);//强制转换成char类型
            //    }
            //}
            //Console.ReadKey();


            //文本文件写入流
            StreamWriter writer = new StreamWriter("just.txt");//若已存在，则会覆盖旧文件
            while (true)
            {
                string message = Console.ReadLine();//读取用户输入的字符
                if (message == "q")//如果用户输入的是q字符，判断输入完毕
                    break;
                writer.WriteLine(message);//把用户输入的信息写入到writer中国
            }
            writer.Close();
            Console.ReadKey();
        }
    }
}
