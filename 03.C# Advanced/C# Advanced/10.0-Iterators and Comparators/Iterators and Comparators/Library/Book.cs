using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
        public Book(string title,int year,IEnumerable<string> authors )
        {
            this.Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }
    }
}
