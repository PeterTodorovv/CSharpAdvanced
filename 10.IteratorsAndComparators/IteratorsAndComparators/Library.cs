using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    class Library: IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.library = new List<Book>(books);
        }

        private List<Book> library;

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.library);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }



    class LibraryIterator : IEnumerator<Book>
    {
        int index;
        private List<Book> books;
        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public LibraryIterator(List<Book> books)
        {
            Reset();
            this.books = new List<Book>(books);
        }
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++this.index < this.books.Count;
        }

        public void Reset()
        {
            index =-1;
        }
    }
}
