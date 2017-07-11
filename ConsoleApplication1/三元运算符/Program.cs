using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myInteger = 100;
            //string resStr = (myInteger < 10) ? "Less than 10" : "Greater than or equal to 10";
            //Console.WriteLine(resStr);
            //Console.ReadKey();

            //用三元运算符实现判断分数大小的功能
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);

            string resStr = score > 50 ? "您输入的分数大于50" : "您输入的分数小于或等于50";
            Console.WriteLine(resStr);
            Console.ReadKey();
        }
    }
}
