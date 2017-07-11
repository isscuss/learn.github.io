using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数数组
{
    class Program
    {
        //定义一个参数个数不确定的数组，然后求和
        static int Sum(int[] array)//常规的数组参数
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        static int Plus(params int[] array)//参数数组，就是在形参前面加一个修饰符params
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
 
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 24, 57, 36, 27, 28, 80 };
            int sum = Sum(array);
            Console.WriteLine(sum);

            int sum2 = Plus(24, 57, 36, 27, 28, 80);//系统自动构造一个数组存放数字
            Console.WriteLine(sum2);
            Console.ReadKey();

        }
    }
}
