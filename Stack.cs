using System;


namespace Week2Task
{
    public class Stack<T>
    {
        private GeneralClass<T> list = new GeneralClass<T>();

        public void Push(T item)
        {
            this.list.AddToHead(item);
        }
        public Node<T> Pop()
        {
            if (list.Size() == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return this.list.RemoveFromTop();
        }
        public Node<T> Peek()
        {
            if (this.list.IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }
            return this.list.Peek();
        }

        public int Size()
        {
            return this.list.Size();
        }

        public bool IsEmpty()
        {
            return this.list.IsEmpty();
        }
        public void PrintList(Stack<T> singlyList)
        {
            this.list.PrintList(list);
        }

    }
}
