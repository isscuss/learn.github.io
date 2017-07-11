using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //悟空吃桃子，第一天吃掉桃子总数的一半多一个，第二天吃掉桃子总数的一半多一个，以此类推，
            //第n天要吃的时时候，发现只剩下一个桃子了，请输入n，然后求得一开始总共几个桃子并输出该值
            //int n = Convert.ToInt32(Console.ReadLine());//读取输入的值
            //int count = 1;//最后一天只有一个桃子，即第n天，然后往前推
            //for (int i = n - 1; i >= 1; i--)//推算到第一天，刚刚开始的时候，是有多少个桃子的
            //{
            //    count = (count + 1) * 2;
            //}
            //Console.WriteLine(count);
            //Console.ReadKey();


            //输入n个数，用空格隔开，然后选出最小的那个数放在最前面，其余的数字不变位置，输出该数组
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(' ');
            //int[] numArray=new int [strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    numArray[i] = Convert.ToInt32(strArray[i]);
            //}
            //int min = numArray[0];//默认最小值是0号位
            //int minIndex = 0;//默认最小值的索引为0；
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    if (numArray[i] < min)
            //    {
            //        minIndex = i;
            //        min = numArray[i];
            //    }
            //}
            //int temp = numArray[0];//把0号位置变成临时值，准备跟i号索引的数字调换位置咯
            //numArray[0] = numArray[minIndex];
            //numArray[minIndex] = temp;
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    Console.Write(numArray[i] + " ");
            //}
            //Console.ReadKey();


            //一开始有n个整数，然后另外输入一个新的整数x，插入序列中，并且使新的序列依然有序，输出新序列
            int[] numArray = { 0, 4, 67, 88, 7532 };
            int[] numNew = new int[numArray.Length + 1];
            int num = Convert.ToInt32(Console.ReadLine());
            int index = 0;//临时索引，用来存储旧的数组索引
            bool isInsert = false;//判断是否插入的布尔值
            for (int i = 0; i < numNew.Length; i++)
            {
                if (i == numArray.Length&&isInsert==false)//特殊情况处理，输入的数比原来数组的数都大，索引就会超出原来的极限
                {
                    numNew[i] = num;
                    isInsert = true;
                    break;
 
                }
                if (num <= numArray[index]&&isInsert==false)
                {
                    numNew[i] = num;
                    isInsert = true;
                }
                else
                {
                    numNew[i] = numArray[index];
                    index++;
                }
            }
            for (int i = 0; i < numNew.Length; i++)
            {
                Console.Write(numNew[i] + " ");
            }
            Console.ReadKey();
            

        }
    }
}
