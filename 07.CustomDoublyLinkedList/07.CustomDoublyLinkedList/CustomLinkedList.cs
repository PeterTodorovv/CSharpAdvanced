using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class CustomLinkedList<T>
    {
        private LinkedListItem<T> first;
        private LinkedListItem<T> last;
        private int count = 0;
        public void AddFirst(T value)
        {
            LinkedListItem<T> newElement = new LinkedListItem<T>(value);

            if(first == null)
            {
                first = newElement;
                last = newElement;
            }
            else
            {
                newElement.Next = first;
                first.Previus = newElement;
                first = newElement;
            }

            count++;
        }

        public void AddLast(T value)
        {
            LinkedListItem<T> newElement = new LinkedListItem<T>(value);
            if (last == null)
            {
                first = newElement;
                last = newElement;
            }
            else
            {
                newElement.Previus = last;
                last.Next = newElement;
                last = newElement;
            }

            count++;
        }


        public T RemoveFirst()
        {
            if(first == null)
            {
                throw new ArgumentException("The list is empty!");
            }
            else if(first == last)
            {
                T valueToReturn = first.Value;
                first = null;
                last = null;
                count--;
                return valueToReturn;
            }
            else
            {
                T valueToReturn = first.Value;
                first = first.Next;
                first.Previus = null;
                count--;
                return valueToReturn;
            }

        }

        public T RemoveLast()
        {
            if (first == null)
            {
                throw new ArgumentException("The list is empty!");
            }
            else if (first == last)
            {
                T valueToReturn = first.Value;
                first = null;
                last = null;
                count--;
                return valueToReturn;
            }
            else
            {
                T valueToReturn = last.Value;
                last = last.Previus;
                last.Next = null;
                count--;
                return valueToReturn;
            }

        }

        public T[] ToArray()
        {
            var item = first;
            T[] array = new T[count];
            int counter = 0;
            while(item != null)
            {
                array[counter] = item.Value;
                counter++;
                item = item.Next;
            }

            return array;
        }

        public void ForEach(Action<T> action)
        {
            T[] array = ToArray();

            foreach(var item in array)
            {
                action(item);
            }
        }
    }
}
