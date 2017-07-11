using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的递归调用//函数调用自身：递归调用
{
    class Program
    {
        //练习：斐波那契数列f(n)=f(n-1)+f(n-2),f(0)=2,eif(1)=3,求f(40)和f(5)的值是多少
        static int Fei(int n)
        {
            if (n == 0) return 2;
            if (n == 1) return 3;
            return Fei(n - 1) + Fei(n - 2);
        }
        static void Main(string[] args)
        {
            int res1 = Fei(40);
            int res2 = Fei(5);
            Console.WriteLine(res1+" "+res2);
            Console.ReadKey();
        }
    }
}
