using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 线程池
{
    class Program
    {
        static void Test(object state)
        {
            Console.WriteLine("任务开始啦：" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("任务结束");
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            Console.WriteLine("这是主体线程");
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程;
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(Test);//开启一个工作线程
            Console.ReadKey();
        }
    }
}
