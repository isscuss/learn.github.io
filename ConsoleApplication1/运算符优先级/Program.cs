using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12 + 90;
            int num1 = 12 + 90 * 2;
            int num2 = (12 + 90) * 2;
            Console.WriteLine(num + ":" + num1 + ":" + num2);
            Console.ReadKey();
        }
    }
}
