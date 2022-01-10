using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ListyIterator
{
    class ListyIterator<T>
    {
        public ListyIterator()
        {
            this.currentIndex = 0;
        }

        private List<T> items;
        private int currentIndex;

        public bool Move()
        {
            if(currentIndex + 1 == items.Count)
            {
                return false;
            }

            currentIndex++;
            return true;
        }

        public void Create(params T[] items)
        {
            this.items = items.ToList();
        }

        public bool HasNext()
        {
            if (currentIndex + 1 == items.Count)
            {
                return false;
            }
            return true;
        }

        public void Print()
        {
            if (items.Count != 0)
                Console.WriteLine(items[currentIndex]);

            throw new InvalidOperationException("Invalid Operation!");
        }
    }
}
