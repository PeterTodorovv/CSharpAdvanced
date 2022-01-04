using System;
using System.Collections.Generic;
using System.Text;

namespace CustomQueue
{
    class CustomQueue<T>
    {
        private T[] items;
        private const int defaultSize = 4;
        public int Count { get; private set; }

        private const int firstItemIndex = 0;

        public CustomQueue()
        {
            this.items = new T[defaultSize];
            this.Count = 0;
        }

        public void Enque(T element)
        {
            if(Count == items.Length)
            {
                Resize();
            }

            items[Count] = element;
            Count++;
            
        }

        public void ForEach(Action<T> action)
        {
            for(int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        public T Deque()
        {
            IsEmpty();
            var removed = items[firstItemIndex];
            items[firstItemIndex] = default;
            ShiftLeft();
            Count--;
            return removed;
        }

       

        public T Peek()
        {
            IsEmpty();
            return items[firstItemIndex];
        }

        public void Clear()
        {
            IsEmpty();
            Count = 0;
            items = new T[defaultSize];
        }



        private void ShiftLeft()
        {
            for(int i = 1; i < Count; i++)
            {
                items[i - 1] = items[i];
            }
        }

        private void IsEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
        }

        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];

            for(int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }
    }
}
