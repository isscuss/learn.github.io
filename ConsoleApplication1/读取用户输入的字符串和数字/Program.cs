using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 读取用户输入的字符串和数字
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //Console.WriteLine(str);
            //Console.ReadKey();

            string str = Console.ReadLine();
            double num = Convert.ToDouble(str);
            num++;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
