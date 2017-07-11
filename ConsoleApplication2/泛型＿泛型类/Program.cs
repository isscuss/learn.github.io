using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型＿泛型类
{
    class Program
    {
        static void Main(string[] args)
        {
            //var o1 = new ClassA<int>(12, 65);//构造一个int类型的对象
            //string s = o1.GetSum();
            //Console.WriteLine(s);
            //Console.ReadKey();

            var o2 = new ClassA<string>("www.", "baidu.com");
            string s1 = o2.GetSum();
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
