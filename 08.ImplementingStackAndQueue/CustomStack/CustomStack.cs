using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class CustomStack<T>
    {
        private T[] items;
        public int Count { get; private set; }
        private const int InitialCapacity = 4;

        public CustomStack()
        {
            this.Count = 0;
            this.items = new T[InitialCapacity];
        }

        public void Push(T elemet)
        {
            if (Count == this.items.Length)
                Resize();

            this.items[Count] = elemet;
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException();

            var item = items[Count - 1];
            items[Count] = default;
            Count--;

            return item;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException();

            var item = items[Count - 1];
            return item;
        }

        public void ForEach(Action<T> action)
        {
            for(int i = 0; i < this.Count; i++)
            {
                action(items[i]);
            }
        }

        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }
    }
}
