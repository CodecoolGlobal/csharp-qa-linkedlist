using System;
using System.Collections;
using System.Collections.Generic;

namespace QA0415
{
    public class LinkedList<T>: IList<T>
    {
        public LinkedListNode<T> First { get; set; }
        public LinkedListNode<T> Last { get; set; }

        public LinkedList()
        {

        }

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if(this.Last == null)
            {
                this.First = new LinkedListNode<T>(item);
                this.Last = this.First;
            } else
            {
                var newNode = new LinkedListNode<T>(item);
                this.Last.Next = newNode;
                this.Last = newNode;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this.First);
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
