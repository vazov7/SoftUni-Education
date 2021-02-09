using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library<T> : IEnumerable<Book> where T : Book
    {
        private readonly List<Book> books;
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }
        public Library(IEnumerable<Book> books)
        {
            this.books = new List<Book>(books);
        }
        public Library()
        {
            books = new List<Book>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        } 
    }
}
