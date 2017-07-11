using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 使用File读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法1 
            //string[] data= File.ReadAllLines("TextFile1.txt");//把每一行的文本，转换成一个字符串
            //foreach (var d in data)
            //{
            //    Console.WriteLine(d);
            //}
            //Console.ReadKey();

            //方法2
            //string d = File.ReadAllText("TextFile1.txt");//读取文本，变成一个字符串
            //Console.WriteLine(d);
            //Console.ReadKey();

            //方法3 读取非文本类型
            //byte[] d = File.ReadAllBytes("5.jpg");//读取字节
            //foreach (var s in d)
            //{
            //    Console.Write(s);
            //}
            //Console.ReadKey();

            //方法4 写入文本
            //File.WriteAllText("isscuss.txt", "hello 伊撒斯");
            //Console.ReadKey();

            //方法5 写入文本数组
            //File.WriteAllLines("another.txt", new string[] { "ada", "sfs", "123f", "什么东西", "乱七八糟adf554" });
            //Console.ReadKey();

            //方法6 复制文件
            byte[] data = File.ReadAllBytes("BAAD - 君が好きだと叫びたい.mp3");
            File.WriteAllBytes("naive.mp3", data);
            Console.ReadKey();
        }
    }
}
