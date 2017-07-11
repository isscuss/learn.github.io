using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> plus = delegate(int arg1, int arg2)
            {
                return arg1 + arg2;
            };
            Console.ReadKey();
        }
    }
}
