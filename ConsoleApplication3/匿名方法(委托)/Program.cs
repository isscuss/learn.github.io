using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法_委托_
{
    class Program
    {
        static int Test(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Func<int, int, int> plus = Test;//常规的委托赋值
            Func<int, int, int> plus = delegate(int a, int b)
            {
                return a + b;
            };//匿名方法赋值
            Console.WriteLine(plus(6, 6));
            Console.ReadKey();
        }
    }
}
