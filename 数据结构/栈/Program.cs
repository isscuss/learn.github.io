using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈
{
    class Program
    {
        static void Main(string[] args)
        {
           // Stack<char> stack = new Stack<char>();
            IStackDs<char> stack = new SeqStack<char>(30);
            //IStackDs<char> stack = new LinkStack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine("push之后的数据个数：" + stack.Count);
            char temp = stack.Pop();
            Console.WriteLine("pop之后得到的数据是：" + temp);
            Console.WriteLine("pop之后数据个数是：" + stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine("peek得到的数据是：" + temp2);
            Console.WriteLine("peek之后的得到的数据是：" + stack.Count);
            stack.Clear();
            Console.WriteLine("clear之后的数据个数是：" + stack.Count);
            Console.ReadKey();
        }
    }
}
