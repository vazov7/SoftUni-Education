using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currentIndex = -1;
        public LibraryIterator(List<Book> books)
        {
            this.books = books;
        }

        public Library.Book Current => books[currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}