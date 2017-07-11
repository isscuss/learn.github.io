using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //发工资时，有面额100，50，20，5，2，1的金额，请问财务部的人，在知道员工工资总额的情况下
            //应该怎么发工资，才不需要找零，输入员工工资总额，输出金额的分配情况
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count100 = num / 100;
            //int remain = num % 100;//除以100的余数，再拿去除以50，以此类推咯
            //int count50 = remain / 50;
            //remain = remain % 50;
            //int count20 = remain / 20;
            //remain = remain % 20;
            //int count5 = remain / 5;
            //remain = remain % 5;
            //int count2 = remain / 2;
            //remain = remain % 2;
            //Console.WriteLine("一百元需准备：" + count100);
            //Console.WriteLine("五十元需准备：" + count50);
            //Console.WriteLine("二十元需准备：" + count20);
            //Console.WriteLine("五元需准备：" + count5);
            //Console.WriteLine("两元元需准备：" + count2);
            //Console.WriteLine("一元需准备：" + remain);
            //Console.ReadKey();


            //判断输入的C#标识符是否合法
            string str = Console.ReadLine();
            bool isRight = true;
            if ((str[0] >= 'a' && str[0] <= 'z') || (str[0] >= 'A' && str[0] <= 'Z') || str[0] == '_' || str[0] == '@')
            {

            }
            else
            {
                isRight = false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '_' || (str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= '0' && str[i] <= '9'))
                {

                }
                else 
                {
                    isRight = false;
                }
            }
            if (isRight == true)
            {
                Console.WriteLine("您输入的标识符是合法的");
            }
            else
            {
                Console.WriteLine("您输入的标识符是非法的");
            }
                Console.ReadKey();

        }
    }
}
