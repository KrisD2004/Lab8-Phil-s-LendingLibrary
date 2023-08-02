# Lab8- Phil’s-Lending-Library

# Phil's Lending Library - README
## Summary
Phil's Lending Library is a C# module that allows users to manage a simple library system. Users can view all available books, add new books to the library, borrow books, search for books, return books, and exit the library.

## Visuals
There are no visuals provided in the code, but the library can be run in a console application, where users will be presented with a menu of options to interact with the library.

## How to Use

View all books:
Select option 1 from the menu to view all the books available in the library.

Add a book:
Select option 2 from the menu.
Enter the title and author of the book when prompted.
The book will be added to the library's collection.

Borrow a book:
Select option 3 from the menu.
Enter the title of the book you want to borrow.
If the book is available, it will be borrowed and added to your backpack.

Search for a book:
Select option 4 from the menu.
Enter the title of the book you want to search for.
If the book is in the library, its details will be displayed.

Return a book:
Select option 5 from the menu.
View the books in your backpack.
Enter the number corresponding to the book you want to return.
The book will be returned to the library's collection.

Exit:
Select option 6 from the menu to exit the library.


## Other Details
The library uses a dictionary to store the books, where the title is the key and the Book object is the value.
The Library class implements the ILibrary interface, which defines the methods for adding, borrowing, and returning books.
The Backpack class implements the IBag<Book> interface, which defines the methods for packing and unpacking books from the backpack.
The LinkedList class is not relevant to the library's functionality and can be ignored.
Please note that this README provides an overview of the library's functionality based on the code provided. For a complete understanding of the module and its implementation, it's recommended to review the source code. Happy borrowing and enjoy your time at Phil's Lending Library!
