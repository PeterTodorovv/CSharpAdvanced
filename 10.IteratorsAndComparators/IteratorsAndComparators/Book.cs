using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
