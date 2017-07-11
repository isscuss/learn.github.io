using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环的终止语句break
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{
            //    Console.WriteLine(index);
            //    if (index == 9)
            //    {
            //        break;
            //    }
            //    index++;
            //}
            //Console.ReadKey();

            //读取用户输入，如果输入0，则结束程序
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "0")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
