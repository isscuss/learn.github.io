using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对数组的排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求用户输入一组整数，以空格区分开，然后进行排序
            //内置的sort排序(CLR中的快速排序方法
            string str = Console.ReadLine();//输出数值
            string[] strArray = str.Split(' ');//利用split（）方法识别空格的存在
            int[] numArray = new int[strArray.Length];//定义一个数字数组来存放strArray
            for (int i = 0; i < strArray.Length; i++)
            {
                int temp = Convert.ToInt32(strArray[i]);
                numArray[i]=temp;
            }
            //Array.Sort(numArray);//直接调用CLR中的Sort方法

            //下面用的是经典的冒泡排序算法，进行排序
            for (int j = 0; j < strArray.Length-1;j++ )//外层for循环用来控制内循环使用次数
            {
                for (int i = 0; i < numArray.Length - 1; i++)
                {
                    if (numArray[i + 1] < numArray[i])//第i个和第i+1个进行比较
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = temp;

                    }
                }
            }
         
                for (int i = 0; i < numArray.Length; i++)
                {
                    Console.Write(numArray[i] + " ");
                }
            Console.ReadKey();
        }
    }
}
