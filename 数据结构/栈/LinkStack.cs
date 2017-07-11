using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 栈
{
    class LinkStack<T>:IStackDs<T>
    {
        private Node<T> top;
        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            count = 0;
            top = null;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        public T Peek()
        {
            return top.Data;
        }
    }
}
