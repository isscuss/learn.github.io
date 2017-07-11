using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出1~9
            //int index = 1;
            //while (index <= 9)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //do while循环
            int index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 9);//跟while的区别在于，do while至少执行一次循环体，while可能一次也不会执行
            Console.ReadKey();
        }
    }
}
