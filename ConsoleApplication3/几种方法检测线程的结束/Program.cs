using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 几种方法检测线程的结束
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
            //Func<int, String, int> a = Test;
            //IAsyncResult ar = a.BeginInvoke(100, " :isscuss", null, null);//开启新的线程，括号中前面的位数，要跟方法体中的参数一致
            //IAsyncResult可以取得当期线程的状态
            //可认为线程是同时执行的（异步执行）
            Console.WriteLine("main");
            
            
            //1.用等待句柄，检测线程结束
            //bool isEnd= ar.AsyncWaitHandle.WaitOne(1000);//ep：等待1000毫秒，在时间内结束则返回true，否则返回false
            //{
            //    int res = a.EndInvoke(ar);
            //    Console.WriteLine(res);
            //}
            //Console.ReadKey();


            //2.通过回调，检测线程结束,先重新开启一个线程
            //Func<int, String, int> a = Test;
            //IAsyncResult ar = a.BeginInvoke(100, " :isscuss", OnCallBack, a);
            ////开启新的线程，倒数第二个参数时委托型参数，是回调（线程结束时，会调用的参数）,最后一位是给回调，传递数据的，任何数据类型
            //Console.ReadKey();


            //3.最简单，通过Lambda表达式，检测线程是否结束
            Func<int, string, int> a = Test;
            a.BeginInvoke(90, "isscuss", ar =>
                {
                    int res = a.EndInvoke(ar);
                    Console.WriteLine(res + "在Lambda中取得的返回值");
                }
                , null);
            Console.ReadKey();
        }
        static void OnCallBack(IAsyncResult ar)//定义回调函数
        {
            Func<int, string, int> a = ar.AsyncState as Func<int, string, int>;
            int res = a.EndInvoke(ar);//取得返回值
            Console.WriteLine(res + ":在回调中取得的返回值");
        }
    }
}
