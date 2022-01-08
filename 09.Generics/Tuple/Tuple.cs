using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class Tuple<T, T2, T3>
    {
        public T item1 { get; set; }
        public T2 item2 { get; set; }
        public T3 item3 { get; set; }

        public Tuple(T item1, T2 item2, T3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }
    }
}
