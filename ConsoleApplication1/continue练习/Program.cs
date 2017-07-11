using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求出1~1000之间所有能被7整除的数，并计算和输出每5个的和
            //int sum = 0;
            //int index = 0;
            //int count = 0;
            //while (true)
            //{
            //    index++;
            //    if (index % 7 != 0) 
            //    {
            //        continue;
            //    }
            //    sum += index;
            //    count++;
            //    if(count==5)
            //    {
            //        Console.WriteLine(sum);
            //        count = 0;
            //        sum = 0;
            //    }
            //    if (index > 1000)
            //    {
            //        break;
            //    }
                
            // }
            //Console.ReadKey();


            //输入4个整数，求出最大值和最小值，并显示出来
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //int max, min;
            //if (num1 > num2)
            //{
            //    max = num1;
            //}
            //else
            //{
            //    max = num2;
            //}
            //if (num3 > max)
            //{
            //    max = num3;
            //}
            //if (num4 > max)
            //{
            //    max = num4;
            //}
            //if (num1 < num2)
            //{
            //    min = num1;
            //}
            //else
            //{
            //    min = num2;
            //}
            //if (num3 < min)
            //{
            //    min = num3;
            //}
            //if (num4 < min)
            //{
            //    min = num4;
            //}
            //Console.WriteLine("最大值是：" + max + "最小值是：" + min);
            //Console.ReadKey();


            //输入两个整数，然后输入0~3分别代表加减乘除，输出计算结果
            //Console.WriteLine("请输入第一个整数:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个整数:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入0~3其中一个数：");
            //int operation = Convert.ToInt32(Console.ReadLine());
            //int res = 0;
            //switch (operation)
            //{
            //    case 0:
            //        res = num1 + num2;
            //        break;
            //    case 1:
            //        res = num1 - num2;
            //        break;
            //    case 2:
            //        res = num1 * num2;
            //        break;
            //    case 3:
            //        res = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("输入有误，怎么可能得到结果呢，哈哈哈");
            //        break;

            //}
            //Console.WriteLine("结果呢，就是：" + res);
            //Console.ReadKey();



            //求出1~1000之间所有能被7整除的数，并计算和输出每5个的和
            //int count = 0;
            //int sum = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sum += i;
            //        count++;
            //        Console.WriteLine(i + "可以被7整除");
            //        if (count == 5)
            //        {
            //            Console.WriteLine("这5个的和是：" + sum);
            //            sum = 0;
            //            count = 0;
            //        }
            //    }
            //}
            //Console.ReadKey();


            //输出1~100之间的平方，平方根
            for (int i = 1; i <= 100; i++)
            {
                int pngfang = i * i;
                double gen = Math.Sqrt(i);
                Console.WriteLine("平方为：" + pngfang + "平方根为：" + gen);
            }
            Console.ReadKey();
        }
    }
}
