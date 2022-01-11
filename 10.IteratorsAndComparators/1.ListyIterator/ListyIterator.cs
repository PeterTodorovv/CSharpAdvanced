using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ListyIterator
{
    class ListyIterator<T>: IEnumerable<T>
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

        public void Create(T[] items)
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
            else
                throw new InvalidOperationException("Invalid Operation!");
        }

        public void PrintAll()
        {
            foreach(var item in items)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(); 
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
