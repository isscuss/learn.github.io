using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 线程争用问题
{
    class Program
    {
        static void ChangeState(object o)
        {
            MyThreadObject m = o as MyThreadObject;
            while (true)
            {
                lock (m)//向系统申请，是否可以锁定m对象，如果可以锁定，则锁住，确保只有一个线程在调用该变量
                {
                    m.ChangeState();
                }
 
            }
        }
        static void Main(string[] args)
        {
            MyThreadObject m = new MyThreadObject();//实例化
            Thread t = new Thread(ChangeState);//
            t.Start(m);
            new Thread(ChangeState).Start(m);//弄个新的线程，玩一玩
            Console.ReadKey();
        }
    }
}
