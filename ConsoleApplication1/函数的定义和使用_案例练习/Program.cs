using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的定义和使用_案例练习
{
    class Program
    {
        //定义一个函数，取得一个数的所有因子，并返回（因子从1到它自身的范围）
        static int[] GetDivisor(int number)//返回的是一个数组
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
 
            }
            int[] array = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
 
        }

        //定义一个函数，输入数组，然后取得数组的中的最大值
        static int Max(int[] array)
        {
            int max = array[0];//先把数组中，0号位置的数定义为最大值，然后依次跟后面的数进行比较
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
            //int num = Convert.ToInt32(Console.ReadLine());//输入一个整数
            //int[] array = GetDivisor(num);//调用GetDivisor函数
            //foreach (int temp in array)//遍历array中的每一个数，然后输出
            //{
            //    Console.Write(temp + " ");
            //}
            //Console.ReadKey();


            int[] array = { 12, 56, 78, 54, 899, 35 };
            Console.WriteLine(Max(array));
            Console.ReadKey();

        }
    }
}
