using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 任务的连续和父子层次结构
{
    class Program
    {
        //父子层次结构
        static void ParentTask()
        {
            Console.WriteLine("task id " + Task.CurrentId);
            var child = new Task(ChildTask);//在父任务中，开启子任务
            child.Start();
            Thread.Sleep(1000);
            Console.WriteLine("父任务完成");
        }
        static void ChildTask()
        {
            Console.WriteLine("cild");
            Thread.Sleep(5000);
            Console.WriteLine("子任务完成");
        }
        static void Main(string[] args)
        {

            var parent = new Task(ParentTask);
            parent.Start();
            Thread.Sleep(2000);
            Console.WriteLine(parent.Status);//输出、查看父任务的状态
            Thread.Sleep(4000);
            Console.WriteLine(parent.Status);//输出、查看父任务的状态
            Console.ReadKey();
        }
    }
}
