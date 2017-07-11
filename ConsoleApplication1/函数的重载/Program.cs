using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的重载//overload
{
    class Program
    {
        static int MaxValue(params int[] array)//int类型的函数
        {
            Console.WriteLine("int类型的函数被调用啦");
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double MaxValue(params double[] array)//double类型的函数
        {
            Console.WriteLine("double类型的函数被调用啦");
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int res1 = MaxValue(24, 567, 376, 2);
            double res2 = MaxValue(24.5, 78.7, 676.3);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();

        }
    }
}
