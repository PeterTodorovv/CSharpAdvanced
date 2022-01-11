using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _7.CustomLinkedList
{
    class CustomLinkedList<T>: IEnumerable<T>
    {
        public Node<T> first;
        public Node<T> last;
        int Count = 0;

        public void Add(T value)
        {
            Count++;
            Node<T> temp = new Node<T>(value);
            if(first == null)
            {
                first = temp;
                last = temp;
            }
            else if(first == last)
            {
                last = temp;
                first.Next = last;
                last.Previous = first;
            }
            else
            {
                last.Next = temp;
                temp.Previous = last;
                last = temp;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class Enumerator<T> : IEnumerator<T>
    {
        public Enumerator(Node<T> first)
        {
            Reset();
            this.first.Next = first;
            currentNode = this.first;
        }

        private Node<T> currentNode;
        private Node<T> first = new Node<T>(default);
        public T Current => currentNode.value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(currentNode.Next == null)
            {
                return false;
            }
            currentNode = currentNode.Next;
            return true;
                       
        }

        public void Reset()
        {
            currentNode = first;
        }
    }
}
