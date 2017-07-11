using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入斐波那契数列哪一项的数值：");
            int number = Convert.ToInt32(Console.ReadLine());//接收用户的键盘输入字符，转换成整形
            Console.WriteLine("斐波那契数列的第{0}项数值为：{1}", number, digui(number));
            Console.ReadKey();
        }
        public static int digui(int sum)
        {
            if (sum == 1 || sum == 2)
            {
                return 1;
            }
            else 
            {
                return sum = digui(sum - 1) + digui(sum - 2);//若返回（sum-1）和（sum-2）的和
            }
        }
    }
}
