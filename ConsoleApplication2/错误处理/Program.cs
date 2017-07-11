using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 错误处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //try...catch...final...
            try
            {
                int[] myArray = { 1, 2, 3, 4 };
                int myEle = myArray[4];//典型的下标越界错误嘛
            }
            catch 
            {
                Console.WriteLine("下标越界啦，大哥");

            }
            finally
            {
                Console.WriteLine("无论如何都会运行到这里哦");
            }
           
            Console.WriteLine("test");
            Console.ReadKey();
        }
    }
}
