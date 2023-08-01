using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8__Phil_s_Lending_Library
{
    internal class Backpack : IBag<Book>
    {
        private List<Book> Storage;
        public void Pack(Book item)
        {
            Storage.Add(item);
        }
        public Backpack()
        {
            Storage = new List<Book>(); 
        }

        public Book Unpack(int index)
        {
            return Storage[index];
            
        }

        public void ViewBooksinBackpack()
        {
                Console.WriteLine("Here are your Books!");
            for (int i = 0; i < Storage.Count; i++)
            {
                string bookTitle = Storage[i].Title;
                Console.WriteLine($"[{i}] {bookTitle}");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return Storage.GetEnumerator();
        }





    }
}
