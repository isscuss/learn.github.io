using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> queue = new Queue<int>();
            //IQueue<int> queue = new SeqQueue<int>();
            IQueue<int> queue = new LinkQueue<int>();
            queue.Enqueue(23);
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);
            Console.WriteLine("添加了23 4 67 89 之后队列大小为："+queue.Count);
            int i = queue.Dequeue();
            Console.WriteLine("取出队首数据为：" + i);
            Console.WriteLine("出队之后，队列大小为：" + queue.Count);
            int j = queue.Peek();
            Console.WriteLine("peek取得的结果为：" + j);
            Console.WriteLine("peek之后队列大小为：" + queue.Count);
            queue.Clear();
            Console.WriteLine("clear之后队列大小为：" + queue.Count);
            Console.ReadKey();
        }
    }
}
