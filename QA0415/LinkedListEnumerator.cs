using System;
using System.Collections;
using System.Collections.Generic;

namespace QA0415
{
    public class LinkedListEnumerator<T>: IEnumerator<T>
    {
        public LinkedListEnumerator(LinkedListNode<T> first)
        {
            this.Head = first;
            this.isValid = true;
            this.isStarted = false;
        }

        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Current { get; private set; }
        private bool isValid;
        private bool isStarted;

        T IEnumerator<T>.Current
        {
            get
            {
                return Current.Value;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current.Value;
            }
        }

        public void Dispose()
        {
            if (this.Current is IDisposable)
            {
                ((IDisposable)this.Current).Dispose();
            }
        }

        public bool MoveNext()
        {
            if (!this.isValid) throw new InvalidOperationException();

            if(this.Current != null)
            {
                this.Current = this.Current.Next;
                if(this.Current == null)
                {
                    return false;
                }
                return true;
            } else
            {
                if(this.isStarted)
                {
                    return false;
                } else
                {
                    this.Current = this.Head;
                    this.isStarted = true;
                    return true;
                }
            }
        }

        public void Reset()
        {
            this.Current = this.Head;
        }
    }
}
