using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool var = false;
            //if (var == false)
            //    Console.WriteLine("........");
            //Console.WriteLine("if语句后面的语句");

            //练习：判断用户输入的数字是否大于50，大于则输出大于50，否则就输出小于50
            //string str = Console.ReadLine();
            //int num = Convert.ToInt32(str);
            //if (num > 50)
            //    Console.WriteLine("您输入的数字大于50啊");
            //if (num <= 50)
            //    Console.WriteLine("您输入的数字小于等于50啊");

            //if else只能执行其中一个分支，而且肯定会执行其中一个分支
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            if (score > 50)
            {
                score++;
                Console.WriteLine("您输入的数字大于50：\n" + score);
            }
            else
            {
                score--;
                Console.WriteLine("您输入的数字小于50:\n" + score);
            }
            Console.ReadKey();
        }
    }
}
