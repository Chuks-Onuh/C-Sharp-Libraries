using System;


namespace Week2Task
{
    class LinkedList<T>
    {
        public GeneralClass<T> List = new GeneralClass<T>();

        public int Add(T item)
        {
            this.List.AddToTail(item);
            return this.List.Size();
        }

        public bool Remove(T item)
        {
            if (this.List.IsEmpty())
            {
                throw new InvalidOperationException("The List is empty");
            }
            return this.List.Remove(item);
        }

        public bool Check(T item)
        {
            return this.List.Check(item);
        }

        public int Index(T item)
        {
            return this.List.Index(item);
        }
    }
}
