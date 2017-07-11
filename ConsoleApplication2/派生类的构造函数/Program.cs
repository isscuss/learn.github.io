using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //DriverClass num1 = new DriverClass();//无参构造，先调用了父类构造，再调用子类构造         
            //DriverClass num2 = new DriverClass(1, 2);//有参构造，就不会再自动调用无参构造函数了,顺序一样
            //Console.ReadKey();

            //静态static方法
            ClassXyz.z = 100;
            Console.WriteLine(ClassXyz.z);//直接通过类来调用静态字段，而不能通过对象
            ClassXyz.Xyz();
            Console.ReadKey();
        }
    }
}
