using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8__Phil_s_Lending_Library
{
    internal class Library : ILibrary
    {
        private Dictionary<string, Book> Storage;
        public int count { get; set; }


        public Library()
        {
            Storage = new Dictionary<string, Book>();
            Book book1 = new Book("To Kill A MockingBird", "SomeGuy");
            Book book2 = new Book("Americana", "Shemamonda");
            Book book3 = new Book("Berserk", "Kentaro Miura");
            Storage.Add(book1.Title, book1);
            Storage.Add(book2.Title, book2);
            Storage.Add(book3.Title, book3);
        }
        public int Count => throw new NotImplementedException();

        public void Add(string title, string author)
        {
            Book book = new Book(title, $"{author}");

            Storage.Add(book.Title, book);

        }

        public Book Borrow(string title)
        {
            
            // Check if the book exists in the library and return it
            Book returnedBook = Storage.GetValueOrDefault(title);
            Storage.Remove(title);
           return returnedBook;
        }

        public void Return(Book book)
        {
            // Add the book back to the library
            Storage.Add(book.Title, book);
        }

        public Book Search(string title)
        {
            // Search for the book by title in the library
            bool searchedBook = Storage.ContainsKey(title);
            if (searchedBook == true)
            {
                return Storage[title];
            }
            return null;
        }

        public void ViewAllBooks()
        {
            var keys = Storage.Keys;

            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                Console.WriteLine(key);
            }
        }

        //  public int Count => Storage.Count;


        public IEnumerator<Book> GetEnumerator()
        {
            var result = Storage.Values;
            //return result.GetEnumerator();
            foreach (Book book in result)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
