using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环嵌套调用和随机数的生成
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出九九乘法表
            //for (int i = 1; i <10; i++)
            //{
            //    for (int j = i; j < 10; j++)
            //    {
            //        Console.Write(i + "*" + j + "=" + (i * j) + " ");
            //    }
            //    Console.WriteLine();
 
            //}
            //Console.ReadKey();


            //模拟掷骰子100次，打印出各种点数
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(1, 7);
                switch (num)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                }
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.ReadKey();
        }
    }
}
