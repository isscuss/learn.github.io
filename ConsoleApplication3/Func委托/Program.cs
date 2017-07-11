using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func委托
{
    class Program
    {
        static int Test1()
        {
            return 1;
        }
        static string Test2(int i1,int i2)
        {
            int sum = i1 + i2;
            string s = Convert.ToString(sum);
            return s;
        }
        static void Main(string[] args)
        {
            //Func<int> a = Test1;//func委托类型引用的函数方法，必须存在返回值
            //Console.WriteLine(a());
            //Console.ReadKey();

            Func<int, int, string> b = Test2;//Func也可以存在参数，但是泛型中的最后一个，肯定是返回值
            Console.WriteLine(b(2,5));
            Console.ReadKey();
        }
    }
}
