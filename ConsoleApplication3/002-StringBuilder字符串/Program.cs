using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_StringBuilder字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建方法有三种
            //1
            //StringBuilder sb = new StringBuilder("www.baidu.com");//利用构造函数
            //2
            //StringBuilder sb = new StringBuilder(20);//初始化一个空的字符串，容量20
            //3
            StringBuilder sb = new StringBuilder("www.baidu.com", 20);//以上两种方法的结合
            sb.Append("ggsimida");//添加操作
            Console.WriteLine(sb);//输出操作
            sb.Insert(3, "...");//插入
            Console.WriteLine(sb);
            sb.Remove(0, 3);//移除操作
            Console.WriteLine(sb);
            sb.Replace('.', '1');//替代操作
            Console.WriteLine(sb);
            Console.WriteLine(sb.ToString());//把stringbuilder类型变成string类型，不可变了
            Console.ReadKey();
        }
    }
}
