using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈和队列的应用举例丨判断是否为回文
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < str.Length; i++) 
            {
                stack.Push(str[i]);
                queue.Enqueue(str[i]);
            }
            bool isHui = true;
            while (stack.Count > 0) 
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    isHui = false;
                    break;
                }
            }
            Console.WriteLine("是否是回文：" + isHui);
            Console.ReadKey();
        }
    }
}
