using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型_程序运行时的内存使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //Console.ReadKey();

            Test2();
            Console.ReadKey();
        }
        static void Test()
        {
            //引用类型间的赋值转换
            Vector3 v = new Vector3();
            v.x = 100;
            v.y = 100;
            v.z = 100;
            Vector3 v2 = new Vector3();
            v2.x = 200;
            v2.y = 200;
            v2.z = 200;
            v2 = v;//引用类型之间的赋值
            v2.x = 300;
            Console.WriteLine(v.x);
        }

        //引用类型引用的是另一个引用类型，会怎样呢
        static void Test2()
        {
            Vector3[] vArray = new Vector3[] { new Vector3(), new Vector3(), new Vector3() };//数组中引用的是类
            Vector3 v1 = vArray[0];
            vArray[0].x = 100;
            v1.x = 200;
            Console.WriteLine(vArray[0].x);
        }
    }
}
