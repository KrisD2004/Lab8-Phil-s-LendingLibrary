using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8__Phil_s_Lending_Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            //NumberOfPages = numberOfPages;
        }

        /*public override string ToString()
        {
            return $"{Title} by {Author} - {NumberOfPages}";
        }*/ 
    }
}
