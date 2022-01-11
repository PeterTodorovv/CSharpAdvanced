using System;
using System.Collections.Generic;
using System.Text;

namespace _7.CustomLinkedList
{
    class Node<T>
    {
        public Node<T> Previous;
        public Node<T> Next;
        public T value;

        public Node(T value)
        {
            this.value = value;
        }


    }
}
