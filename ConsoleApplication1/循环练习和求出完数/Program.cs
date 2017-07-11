using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环练习和求出完数
{
    class Program
    {
        static void Main(string[] args)
        {
            //满足以下条件：1.接收整数n   2.n为正，则输出1~n间全部整数  3.n为负，用break或return退出
            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        for (int i = 1; i <= num; i++)
            //        {
            //            Console.Write(i + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    else if (num < 0)
            //    {
            //        return;
            //    }
            //}


            //求1000以内的所有“完数”：指一个数恰好等于它的所有因子之和，例如6是完数，6=1+2+3
            for (int i = 1; i < 1001; i++)
            {
                string str = "1";
                int sum = 1;//1是所有自然数的公因数
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        str += "+" + j;
                        sum += j;
                    }
                }
                if(sum==i)
                {
                    Console.WriteLine(i + "是完数" + str);
                }
 
            }
            Console.ReadKey(); 
         
        }
    }
}
