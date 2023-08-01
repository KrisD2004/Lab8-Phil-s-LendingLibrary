namespace Lab8__Phil_s_Lending_Library
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //this library is refercing the constructor method in the library class 
            Console.WriteLine("Hello welcome to my library");
            Library myLibrary = new Library();
            Backpack myBackpack = new Backpack();

            while (true)
            {
                Console.WriteLine("Here are your options:");
                Console.WriteLine("1. View all books");
                Console.WriteLine("2. Add a book");
                Console.WriteLine("3. Borrow a book");
                Console.WriteLine("4. Search for Book");
                Console.WriteLine("5. Return a book");
                Console.WriteLine("6. Exit");
                string input = Console.ReadLine();


                if (input == "1")
                {
                    myLibrary.ViewAllBooks();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Please enter in a title of a book");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Please enter in a Author of a book");
                    string bookAuthor = Console.ReadLine();
                    myLibrary.Add(bookTitle, bookAuthor);

                }
                else if (input == "3")
                {
                    Console.WriteLine("Please enter the title of the book to borrow:");
                    string bookTitle = Console.ReadLine();
                    Book borrowedBook = myLibrary.Borrow(bookTitle);
                    if (borrowedBook != null)
                    {

                        Console.WriteLine($"You borrowed: {borrowedBook.Title} by {borrowedBook.Author}");
                        myBackpack.Pack(borrowedBook);
                    }
                    else
                    {
                        Console.WriteLine("Book not found in the library.");
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Search for a book by title");
                    string userInput = Console.ReadLine();
                    myLibrary.Search(userInput);
                }
                else if (input == "5")
                {
                    myBackpack.ViewBooksinBackpack();
                    Console.WriteLine("Return book by its number");
                   int bookReturn= Convert.ToInt32(Console.ReadLine());
                    Book unpack = myBackpack.Unpack(bookReturn);
                    myLibrary.Add(unpack.Title, unpack.Author);
                    
                }
                else if (input == "6")
                {
                    Console.WriteLine("Exiting the library. Goodbye!");
                    return; // This will break out of the while loop and terminate the program.


                }
                
            }
        }


        }
    }



