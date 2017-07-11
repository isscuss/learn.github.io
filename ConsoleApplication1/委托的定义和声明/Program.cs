using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托的定义和声明
{
    public delegate double MyDelegate(double param1,double param2);//委托是不需要跟函数体{}这些东西的
    class Program
    {
        static double Multiply(double yinzi1, double yinzi2)
        {
            return yinzi1 * yinzi2;
        }

        static double Divide(double beichushu, double chushu)
        {
            return beichushu / chushu;
        }

        static void Main(string[] args)
        {
            MyDelegate de;//定义的委托声明了一个变量=函数
            de = Multiply;
            Console.WriteLine(de(34, 57));
            de = Divide;
            Console.WriteLine(de(34, 57));
            Console.ReadKey();
        }
    }
}
