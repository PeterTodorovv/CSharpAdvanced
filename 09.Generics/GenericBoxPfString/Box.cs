using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxPfString
{   
    class Box<T>
        where T: IComparable
    {
        public T value;

        public Box(T value)
        {
            this.value = value; 
        }

        public override string ToString()
        {
            return $"{value.GetType()}: {value}";
        }
    }
}
