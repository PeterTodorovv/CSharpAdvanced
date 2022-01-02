using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class LinkedListItem<T>
    {
        public LinkedListItem(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }


        public LinkedListItem<T> Previus;
        public LinkedListItem<T> Next;
    }
}
