using System;
namespace QA0415
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        // TODO private set?
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode()
        {
        }

        public LinkedListNode(T item)
        {
            this.Value = item;
        }
    }
}
