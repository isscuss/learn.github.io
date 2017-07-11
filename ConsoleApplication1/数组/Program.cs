using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一种数组的初始化方式
            //int[] scores = { 23, 545, 464, 345, 76, 898, 78, 7 };
            //第二种
            //int[] scores;
            //scores = new int[10];//等同于int[] scores=new int[10];
            //第三种
            //int[] scores = new int[9] { 14, 343, 76, 45, 78, 89, 67, 0, 6 };
            //Console.WriteLine(scores[6]);//访问索引值超出或不存在时，会出现异常exception
            //Console.ReadKey();

            //字符数组的声明
            //char[] charArray = new char[2] { 's', 'd' };//记得字符是单引号的
            //Console.WriteLine(charArray[1]);
            //Console.ReadKey();

            //字符串数组的声明
            string[] names = new string[3] { "adsaf", "adfasf", "cao" };//记得字符串用的是双引号啊
            Console.WriteLine(names[2]);
            Console.ReadKey();
        }
    }
}
