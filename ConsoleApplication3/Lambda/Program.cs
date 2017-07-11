using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{   class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> plus = (arg1, arg2) => //lambda表达式必须的格式
            //    {
            //        return arg1 + arg2;
            //    };
            //Console.WriteLine(plus(90, 60));
            //Console.ReadKey();

            //Func<int, int> test = a => a + 1;//lambda更简单的形式，只有一个参数时，省去括号
            //Console.WriteLine(test(35));
            //Console.ReadKey();

            //通过lambda还可以访问表达块外部变量，方便但是危险
            int temp = 5;
            Func<int, int> f = x => x + temp;
            Console.WriteLine(f(3));
            temp = 6;//外部变量的改变，表达式结果也会被改变，可能导致结果不可控
            Console.WriteLine(f(3));
            Console.ReadKey();

        }
    }
}
