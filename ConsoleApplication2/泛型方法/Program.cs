using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型方法
{
    class Program
    {
        public static string GetSum<T,T2,T3>(T a, T b)//也可以声明多个泛型类型tT,T2,T3，但是调用时，必须全部定义好
        {
            return a + "" + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum<int, string, int>(12, 35));
            Console.ReadKey();
        }

  
    }
}
