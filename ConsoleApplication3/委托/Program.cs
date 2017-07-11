using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        private delegate string GetAString();//定义一个委托类型
        static void Main(string[] args)
        {
            //int x = 20;
            ////GetAString a = new GetAString(x.ToString);//实例化,指向ToString方法
            //GetAString a = x.ToString;//委托变量赋值，直接用方法进行初始化，就ok了
            //string s = a();//通过委托，调用该方法
            ////string s=a.invoke();//调用方法的另一种途径
            //Console.WriteLine(s);
            //Console.ReadKey();

            //2.使用委托类型作为方法的参数

            PrintString method = Method1;
            PrintStr(method);
            PrintString method2 = Method2;
            PrintStr(method2);
            Console.ReadKey();
        }
        private delegate void PrintString();

        static void PrintStr(PrintString print)//把委托类型作为方法的参数，进行传递
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("方法1");
        }
        static void Method2()
        {
            Console.WriteLine("方法2");
        }
    }
}
