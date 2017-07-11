using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自加和自减
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 45;
            ////int res = num++;//45
            //int res = ++num;//46
            //Console.WriteLine(res + ":" + num);
            int num = 45;
            int res1 = num--, res2 = --num;
            Console.WriteLine(res1 + ":" + res2);
            Console.ReadKey();
        }
    }
}
