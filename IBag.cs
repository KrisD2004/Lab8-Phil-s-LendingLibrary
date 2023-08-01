using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8__Phil_s_Lending_Library
{
    public interface IBag<Book> : IEnumerable<Book>
    {

        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        void Pack(Book item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        Book Unpack(int index);
    }
}
