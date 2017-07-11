using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1;//使用Customer模板，声明一个变量customer1
            customer1 = new Customer();//对象的初始化
            customer1.name = "balls";//赋值
            Console.WriteLine(customer1.name);
            customer1.Show();//调用对象中的方法体
            Console.ReadKey();
        }
    }
}
