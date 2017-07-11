using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 后台和前台线程_优先级_状态什么的
{
    class Program
    {
        static void DonloadFile(object filename)//被线程调用的函数,传递的参数必须是object类型的
        {
            Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId + "传递的是:" + filename);
            Thread.Sleep(2000);
            Console.WriteLine("下载完毕");
        }
        static void Main(string[] args)//默认为前台线程
        {
            //后台线程的设置
            Thread t = new Thread(DonloadFile);
            t.IsBackground = true;//后台线程
            t.Start("什么东西嘛");
            //t.Join();//除t以外的线程，睡眠，等待t线程运行结束，才会继续进行下面的代码
            Console.WriteLine("这是主体线程");
            Thread.Sleep(1000);

        }
    }
}
