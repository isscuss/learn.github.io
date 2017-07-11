using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 任务
{
    class Program
    {
        static void TheadMethod()
        {
            Console.WriteLine("任务开始");
            Thread.Sleep(2000);
            Console.WriteLine("任务结束");
        }
        static void Main(string[] args)
        {
            //方法1 开启任务
            //Task t = new Task(TheadMethod);
            //t.Start();
            //Console.WriteLine("main");
            //Console.ReadKey();

            //方法2 开启任务
            TaskFactory tf = new TaskFactory();
            Task t = tf.StartNew(TheadMethod);
            Console.WriteLine("main");
            Console.ReadKey();
        }
    }
}
