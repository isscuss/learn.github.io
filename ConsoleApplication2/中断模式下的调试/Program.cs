using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中断模式下的调试
{
    class Program
    {
        static void Test ()
        {
            Console.WriteLine("test method");
        }
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 67;
            Test();
            int sum = num1 + num2;
            string name = "balls";
            Console.WriteLine(sum);
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
