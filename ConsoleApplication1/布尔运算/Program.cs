using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 布尔运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //int score = 30;
            //bool res = score >= 50;
            //Console.WriteLine(res);

            //各种布尔运算符
            //int num1 = 56;
            //int num2 = 67;
            //bool res1 = num1 == num2;
            //bool res2 = num1 != num2;
            //bool res3 = num1 < num2;
            //bool res4 = num1 > num2;
            //bool res5 = num1 <= num2;
            //bool res6 = num1 >= num2;
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.WriteLine(res5);
            //Console.WriteLine(res6);

            //条件布尔运算符
            bool var1 = true;
            bool var2 = false;
            bool res = !var1;//取反
            bool res1 = var1 & var2;//与
            bool res2 = var1 | var2;//或
            bool res3 = var1 ^ var2;//异或
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.ReadKey();
        }
    }
}
