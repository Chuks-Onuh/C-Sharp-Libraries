using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Task
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
        }

        public Node<T> Head { get; internal set; }
    }
}
