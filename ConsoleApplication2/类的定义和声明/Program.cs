using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _类的定义和声明
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //Vehicle car1 = new Vehicle();
            //car1.speed = 100;
            //car1.Run();
            //car1.Stop();
            //Console.WriteLine(car1.speed);
            //Console.ReadKey();

            //Vector v1 = new Vector();
            //v1.SetX(1);
            //v1.SetY(2);
            //v1.SetZ(3);
            //Console.WriteLine(v1.Length());
            //Console.ReadKey();

            //构造函数的运用
            //Vector v1 = new Vector(1, 1, 6);
            //Console.WriteLine(v1.Length());
            //Console.ReadKey();

            //使用属性
            Vector v1 = new Vector();
            v1.X = 100;
            Console.WriteLine(v1.X);
            v1.Name = "balls";
            Console.WriteLine(v1.Name);
            v1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(v1.Age);
            Console.ReadKey();
        }
    }
}
