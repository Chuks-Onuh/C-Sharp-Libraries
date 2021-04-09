using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Week2Task
{
    class Queue<T>
    {
        public GeneralClass<T> List = new GeneralClass<T>();
        public bool IsEmpty()
        {
            return this.List.IsEmpty();
        }
        public void Enqueue(T item)
        {
            this.List.AddToTail(item);
        }
        public Node<T> Dequeue()
        {
            if (this.List.IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return this.List.RemoveFromTop();
        }
        public int Size()
        {
            return this.List.Size();
        }
        public void PrintList(Queue<T> singlyList)
        {
            this.List.PrintList(List);
        }
    }
}
