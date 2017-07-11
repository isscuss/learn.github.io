using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环和循环的嵌套调用
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出1~100内，能被3整除，不能被5整除的数，并统计这类数的数目
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if((i%3==0)&&(i%5!=0))
            //    {
            //        Console.WriteLine("这就是被选中的数啊："+i);
            //        sum++;
            //    }
            //}
            //Console.WriteLine("总数为："+sum);
            //Console.ReadKey();


            //求1000以内的素数，或称作质数
            for (int i = 2; i <1001; i++)
            {
                bool isZhishu = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isZhishu = false;
                        break;
                    }
                }
                if (isZhishu)
                {
                    Console.WriteLine(i);
                }
 
            }
            Console.ReadKey();
        }
    }
}
