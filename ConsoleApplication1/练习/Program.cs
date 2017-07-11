using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hp;
            //float x, y, z;
            //float speed = 12;

            //string str1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(str1);
            //string str2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(str2);
            //int temp = num1;
            //num1 = num2;
            //num2 = temp;
            //Console.WriteLine(num1 + ":" + num2);

            //string str1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(str1);
            //string str2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(str2);
            //string str3 = Console.ReadLine();
            //int num3 = Convert.ToInt32(str3);
            //string str4 = Console.ReadLine();
            //int num4 = Convert.ToInt32(str4);
            //int res = num1 * num2 * num3 * num4;
            //Console.WriteLine(res);
            
            //把用户输入的三位数以相反的顺序输出，如输入108，输出801，利用求模运算
            //string str = Console.ReadLine();
            //int num = Convert.ToInt32(str);
            //int ge = num % 10;//一个数字跟10求余，得到的是该数字的个分位
            //int shi = (num / 10) % 10;//一个数字跟10相除，是把该数的个分位去掉，十分位替代个分位
            //int bai = num / 100;
            //Console.WriteLine(ge + "" + shi + "" + bai);
    
            //求梯形的面积
            //Console.WriteLine("请输入上底");
            //string str1 = Console.ReadLine();
            //double num1 = Convert.ToDouble(str1);
            //Console.WriteLine("请输入下底");
            //string str2 = Console.ReadLine();
            //double num2 = Convert.ToDouble(str2);
            //Console.WriteLine("请输入梯形的高");
            //string str3 = Console.ReadLine();
            //double num3 = Convert.ToDouble(str3);
            //Console.WriteLine("梯形的面积是：");
            //double res = (num1 + num2) * num3 / 2;
            //Console.WriteLine(res);

            //输入半径，求圆的周长和面积
            Console.WriteLine("请输入圆的半径：");
            string str = Console.ReadLine();
            double n = Convert.ToDouble(str);
            Console.WriteLine("圆的周长是：" + (2 * n * 3.14));
            Console.WriteLine("圆的面积是：" + (n * n * 3.14));
            Console.ReadKey();
        }
    }
}
