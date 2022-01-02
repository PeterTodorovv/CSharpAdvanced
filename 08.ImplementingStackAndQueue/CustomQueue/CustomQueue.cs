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

        public CustomQueue()
        {
            this.items = new T[defaultSize];
            this.Count = 0;
        }


    }
}
