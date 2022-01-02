using System;
using System.Collections.Generic;
using System.Text;

namespace _08.ImplementingStackAndQueue
{
    class CustomList<T>
    {
        private T[] items;
        private const int defaultValue = 2;
        public int Count { get; private set; }

        public CustomList()
        {
            items = new T[defaultValue];
        }

        public T this[int index]
        {
            get
            {
                if(index >= this.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= this.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Add(T element)
        {
            if (items.Length == Count)
                Resize();

            items[Count] = element;
            Count++;
        }

        public T RemoveAt(int index)
        {
            var item = items[Count];
            items[Count] = default;
            Count--;
            Shift(index);

            if (this.Count <= items.Length / 4)
                this.Shrink();
            return item;
        }

        public bool Contains(T element)
        {
            for(int i = 0; i < Count; i++)
            {
                var item = items[i];
                if (item.Equals(element))
                    return true;
            }

            return false;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            if (items.Length == Count)
                Resize();

            RearrangeRight(index);

            items[index] = item;
            Count++;
        }


        public void Swap(int index1, int index2)
        {
            var temp = items[index1];
            if (index1 >= 0 && index1 < Count && index2 >= 0 && index2 < Count)
            {
                items[index1] = items[index2];
                items[index2] = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        private void RearrangeRight(int index)
        {
            for(int i = Count + 1; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void Shrink()
        {
            T[] newArray = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Resize()
        {
                T[] newArray = new T[items.Length * 2];

                for(int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
        }
    }
}
