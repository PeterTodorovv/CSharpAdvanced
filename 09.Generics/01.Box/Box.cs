using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> list;
        public int Count { get { return this.list.Count; } }


        public Box()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Insert(0, element);
        }

        public T Remove()
        {
            var element = this.list[0];
            list.RemoveAt(0);
            return element;
        }
    }
}
