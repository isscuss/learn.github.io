using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 23, 4, 6, 8, 5, 9, 45, 8, 4 };
            //第一种方法for
            //for (int i = 0; i < scores.Length; i++)//数组长度length-1等于索引max值
            //{
            //    Console.WriteLine(scores[i]);
 
            //}
            //Console.ReadKey();

            //第二种方法while
            //int i = 0;
            //while (i < scores.Length)
            //{
            //    Console.WriteLine(scores[i]);
            //    i++;
            //}
            //Console.ReadKey();

            //第三种方法foreach
            foreach (int temp in scores)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
