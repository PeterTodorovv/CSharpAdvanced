using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _5.ComparingObjects
{
    class Person: IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override int GetHashCode()
        {
            var hashCode = this.Name.Length * 10000;
            hashCode = this.Name.Aggregate(hashCode, (current, letter) => current + letter);
            hashCode += this.Age * 10000;

            return hashCode;
        }

        public override bool Equals(object other)
        {
            var y = other as Person;
            return this.Name == y.Name && this.Age == y.Age;
        }
        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if(result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }
    }
}
