using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三种循环结构的练习和字符_字符串的处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出1~5的平方值 通过三种循环结构，不同的方法实现
            
            //for循环
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i * i);
            //}
            //Console.ReadKey();

            //while循环
            //int index = 1;
            //while (index < 6)
            //{
            //    Console.WriteLine(index * index);
            //    index++;
            //}
            //Console.ReadKey();

            //do while循环
            //int index = 1;
            //do
            //{
            //    Console.WriteLine(index * index);
            //    index++;
            //} while (index < 6);
            //Console.ReadKey();


            //要求输入5个大写字母，如果用户输入信息不满足要求，则给出帮助信息并要求用户重新输入
            while (true)
            {
                string str = Console.ReadLine();
                bool isAllUpperChar = true;
                for (int i = 0; i < 5; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {

                    }
                    else
                    {
                        isAllUpperChar = false;
                        break;
                    }
                }
                if (isAllUpperChar == false)
                {
                    Console.WriteLine("您输入的5个字母，不全是大写字母，请重新输入哦");
                }
                else
                {
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
