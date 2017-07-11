using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Program
    {
        public delegate void MyDelegate();

        //public MyDelegate mydelegate;
        public event MyDelegate mydelegate;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mydelegate = Test1;
            p.mydelegate();
            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("test1");
        }
    }
}
