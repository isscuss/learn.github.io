using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assembly程序集类
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my =new MyClass();
            Assembly assem= my.GetType().Assembly;
            Console.WriteLine(assem.FullName);
            Type[] types = assem.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type);
            }
            Console.ReadKey();
        }
    }
}
