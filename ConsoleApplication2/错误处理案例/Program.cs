using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 错误处理案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入两个数字，用户可能输入非数字类型嘛，就提示用户输入错误咯，请重新输入
            int num1 = 0, num2 = 0;
            Console.WriteLine("请输入第一个数字");
            while (true)
            {
                
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());//可能就会发生formatException：格式化错误咯
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("请输入纯数字类型哦");
 
                }
            }
            Console.WriteLine("请输入第二个数字");
            while (true)
            {
               
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());//可能就会发生formatException：格式化错误咯
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("请输入纯数字类型哦");

                }
            }
            int sum = num1 + num2;
            Console.WriteLine("和就是:" + sum);
            Console.ReadKey();
        }
    }
}
