using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程练习
{
    class Program
    {
        abstract class BaseClass
        {
            public virtual void MethodA() 
            {
                Console.WriteLine("BaseClass");
            }
            public virtual void MethodB() { }
        }
        class Class1 : BaseClass
        {
            public void MethodA() //并没有override,默认会隐藏baseclass中高的methodA（）
            {
                Console.WriteLine("Class1"); 
            }
            public override void MethodB() { }
        }
        class Class2 : Class1
        {
            new public void MethodB() { }
        }
        class MainClass
        {
            public static void Main(string[] args) 
            {
                Class2 o = new Class2();
                o.MethodA();

                Console.ReadKey();
            }
        }

    }
}
