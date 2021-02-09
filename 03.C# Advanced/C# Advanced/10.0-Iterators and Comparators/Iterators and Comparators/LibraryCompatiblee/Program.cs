using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Club 5AM", 2015,new string[]{"Juli Tonkin","Goshko" }),
                new Book("Shtastie", 2017, new string[] { "Albena tonkin", "Juli Tonkin" })
            };
            Library<Book> myLibrary = new Library<Book>(books);

            foreach (var item in myLibrary)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
