using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环结构的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //关系式1*1+2*2+3*3+...+k*k<2000，求k的最大值是多少
            //int sum = 0;
            //int k = 0;
            //while (sum < 2000)
            //{
            //    k++;
            //    sum += k * k;
            //}
            //Console.WriteLine(k - 1);
            //Console.ReadKey();


            //百元买百鸡问题：现有100元，公鸡价格：5元一只，母鸡价格：3元一只，小鸡价格：1元三只，
            //求100元买100只鸡，有几种分配的可能性，打印罗列出来
            for (int i = 0; i <= 100 / 5; i++)//弄多几个for循环出来嗨，这个是公鸡的可能性
            {
                for (int j = 0; j <= (100 - i * 5) / 3; j++)//这是母鸡的可能性
                {
                    int remain = 100 - i * 5 - j * 3;//剩余的钱，就拿来买小鸡咯
                    int chicken = remain * 3;//小鸡的个数
                    if (chicken + i + j == 100)//如果满足100只鸡的要求呢，嘿嘿嘿
                    {
                        Console.WriteLine("公鸡有：" + i + "母鸡有：" + j + "小鸡有：" + chicken);
                    }
                }
 
            }//就是个嵌套循环的东西
            Console.ReadKey();
        }
    }
}
