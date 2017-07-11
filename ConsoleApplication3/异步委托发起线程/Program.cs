using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//线程的命名空间
using System.Threading.Tasks;

namespace 异步委托发起线程
{
    class Program
    {
        static int Test(int i, string str)
        {
            Console.WriteLine("test:" + i + str);
            Thread.Sleep(100);//让当前线程休眠（暂停线程执行） 单位ms
            return 100;
        }
        static void Main(string[] args)
        {
            //通过委托，开启一个线程
            Func<int, String, int> a = Test;
            IAsyncResult ar= a.BeginInvoke(100, " :isscuss", null, null);//开启新的线程，括号中前面的位数，要跟方法体中的参数一致
            //IAsyncResult可以取得当期线程的状态
            //可认为线程是同时执行的（异步执行）
            Console.WriteLine("main");
            while (ar.IsCompleted == false)//建立一个死循环，检测线程是否完成
            {
                Console.Write(".");
                Thread.Sleep(10);//控制子线程的检测频率
            }
            int res= a.EndInvoke(ar);//取得异步线程的返回值
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
