using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto和return跳出循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto语句通过标签跳出
        //    while (true)
        //    {
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        if (num == 0)
        //        {
        //            goto labeel;
        //        }
        //    }
        //labeel: Console.WriteLine("我终于跳出循环啦，沃日！！");
        //Console.ReadKey();

            //return语句不用标签，直接跳出该方法体，贼吊
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
            }
            Console.ReadKey();
        }
    }
}
