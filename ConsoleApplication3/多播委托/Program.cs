using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多播委托
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("测试1");
        }

        static void Test2()
        {
            Console.WriteLine("测试2");
        }
        static void Main(string[] args)
        {
            Action a = Test1;
            a += Test2;//多播委托的实现
            a();
            Delegate[] delegates = a.GetInvocationList();//通过GetInvocationList方法可得到多播委托的集合,并返回

            foreach (Delegate tmep in delegates)
            {
                tmep.DynamicInvoke();//DynamicInvoke方法中可传递参数，不过这里都是void，就不用这些东西了，哈哈
            }
            Console.ReadKey();


        }
    }
}
