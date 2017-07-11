using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的定义
{
    class Program
    {
        static void Write() //void表示空的返回值，就是不需要返回值
        {
            Console.WriteLine("text output from here");
            return;//这句话用来结束当前函数
        
        }

        static int Plus(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static void Main(string[] args)
        {
            Write();//函数的调用，函数名加上括号，括号内写参数，当然没有就不用写啦
            int num1 = 56;
            int num2 = 77;
            int res1=Plus(num1, num2);
            int res2=Plus(78, 22);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
