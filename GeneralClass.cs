using System;


namespace Week2Task
{
    public class GeneralClass<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        private int count = 0;


        public int AddToTail(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this.Head == null)
            {
                newNode.Next = Head;
                this.Head = newNode;
                this.Tail = this.Head;
                ++count;
            }
            else
            {
                Node<T> prev = this.Tail;
                this.Tail.Next = newNode;
                this.Tail = newNode;
                ++count;
            }

            return count;
        }

        public int AddToHead(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = this.Head;
            this.Head = newNode;
            ++count;
            return count;
        }

        public Node<T> Peek()
        {
            return this.Head;
        }

        public bool Remove(T item)
        {
            Node<T> temp = this.Head;
            Node<T> prev = null;
            if (temp != null && temp.Data.Equals(item))
            {
                this.Head = temp.Next;
                --this.count;
                return true;
            }
            while (temp != null && !temp.Data.Equals(item))
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                return false;
            }
            prev.Next = temp.Next;
            --this.count;
            return true;
        }

        public Node<T> RemoveFromTop()
        {
            Node<T> returnValue = this.Head;
            this.Head = this.Head.Next;
            count--;
            return returnValue;
        }

        public bool Check(T item)
        {
            Node<T> temp = this.Head;
            while (temp != null)
            {
                if (temp.Data.Equals(item)) return true;
                temp = temp.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            int index = 0;
            Node<T> temp = this.Head;
            if (temp != null && temp.Data.Equals(item))
            {
                ++index;
                return 0;
            }
            while (temp != null && !temp.Data.Equals(item))
            {
                temp = temp.Next;
                ++index;
            }
            if (temp == null)
            {
                return -1;
            }
            return index;
        }

        public int Size()
        {
            return this.count;
        }

        public bool IsEmpty()
        {
            return count == 0 ? true : false;
        }
        public void PrintList(GeneralClass<T> singlyList)
        {
            Node<T> n = singlyList.Head;
            while (n != null)
            {
                Console.Write(n.Data + " ");
                n = n.Next;
            }
        }
    }
}
