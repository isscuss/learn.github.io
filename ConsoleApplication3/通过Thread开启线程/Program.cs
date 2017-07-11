using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 通过Thread开启线程
{
    class Program
    {
        static void DonloadFile(object filename)//被线程调用的函数,传递的参数必须是object类型的
        {
            Console.WriteLine("开始下载"+Thread.CurrentThread.ManagedThreadId+"传递的是:"+filename);
            Thread.Sleep(2000);
            Console.WriteLine("下载完毕");
        }
        static void Main(string[] args)
        {
            //方法1
            //Thread t = new Thread(DonloadFile);
            //t.Start();
            //Console.WriteLine("主体函数");
            //Console.ReadKey();

            //方法2 通过Lambda方法开启线程
            //Thread t = new Thread(() =>
            //    {
            //        Console.WriteLine("开始下载：" + Thread.CurrentThread.ManagedThreadId);
            //        Thread.Sleep(2000);
            //        Console.WriteLine("下载完毕");
            //    }
            //    );
            //t.Start();
            //Console.ReadKey();

            //方法3 通过线程传递参数
            //Thread t = new Thread(DonloadFile);
            //Console.WriteLine("Main");
            //t.Start("什么乱七八糟的参数嘛");//通过start方法传递参数
            //Console.ReadKey();

            //方法4 通过新建一个线程类，定义需要传递的参数和传递的方法,进行参数的传递
            Mythread my = new Mythread("路径什么的：", "需要种子吗");
            Thread t = new Thread(my.DownFile);//通过构造出来的my，可以调用其中的函数，不一定是静态
            t.Start();
            Console.ReadKey();

        }
    }
}
