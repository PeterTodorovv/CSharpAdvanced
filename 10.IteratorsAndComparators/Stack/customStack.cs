using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class customStack<T>: IEnumerable<T>
    {

        public customStack()
        {
            this.elements = new List<T>();
        } 

        private List<T> elements;

        public void Push(T[] newElements)
        {
            foreach(var element in newElements)
            {
                elements.Add(element);
            }
        }

        public T Pop()
        {
            if(elements.Count == 0)
            {
                Console.WriteLine("No elements");
                return default;
            }
            var element = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
