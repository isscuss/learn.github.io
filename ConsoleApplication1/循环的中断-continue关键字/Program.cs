using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环的中断_continue关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue会中断这一次循环，但是会继续进行下一次循环，这就是中断的意义
            //int index = 1;
            //while (true)
            //{
            //    index++;
            //    if (index == 5)
            //    {
            //        continue;
            //    }
            //    if (index == 10)
            //    {
            //        break;
            //    }
         
            //    Console.WriteLine(index);
            //}
            //Console.ReadKey();

            //练习：用户输入整数，大于0偶数则相加，大于0奇数则不相加，0则直接跳出程序
            int sum=0;
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 1) //如果输入是奇数，奇数除以2，肯定是余1的
                {
                    continue;
                }
                if (num == 0)
                {
                    break;
                }
                sum +=num;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
                
        }
    }
}
