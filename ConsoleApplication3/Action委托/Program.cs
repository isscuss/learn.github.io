using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托
{
    class Program
    {
        static void Print()
        {
            Console.WriteLine("惊喜吧！");
        }
        static void PrintInt(int i1,int i2)
        {
            Console.WriteLine(i1 + i2);
        }
        static void Main(string[] args)
        {
            //Action a = Print;//初始化（无参数，无返回值）
            //a();//运行程序
            //Console.ReadKey();

            Action<int, int> b = PrintInt;//扩展，Action委托类型后面跟一个泛型，其中添加参数，最多添加16个，要跟引用类型一一对应
            b(3,5);
            Console.ReadKey();
        }
    }
}
