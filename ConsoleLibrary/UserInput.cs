using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLibrary
{
    class UserInput
    {
        public void UserInputs()
        {
            bool onWork = false;

            while (!onWork)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("1 - See all the books listed in the bookshelf.");
                Console.WriteLine("2 - Add a new book into the bookshelf.");
                Console.WriteLine("3 - Close the program.");
                Console.WriteLine("==============================================");

                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    ListedBooksBookshelf();
                }
                else if (choose == "2")
                {
                    Adding_Book();
                }
                else if (choose == "3")//Close the program
                {
                    onWork = true;
                }
                else
                {
                    Console.WriteLine("Wrong parameter, try again.");
                    Console.WriteLine("");
                }
            }
        }

        static void ListedBooksBookshelf()//See all the books listed in the bookshelf
        {
            Book book = new Book();

            Console.WriteLine($"Currently we have {book.bookShelf.Count} books on the BookShelf");

            foreach (KeyValuePair<string, string> bookPair in book.bookShelf)
            {
                Console.WriteLine($"* {bookPair.Key} - {bookPair.Value}.");
            }
        }
        public Book Adding_Book()//Add a new book into the bookshelf
        {
            string title = string.Empty;
            string author = string.Empty;
            string pages = string.Empty;

            Console.Write("Title: ");
            title = Console.ReadLine();

            Console.Write("Author: ");
            author = Console.ReadLine();

            Console.Write("Pages: ");
            pages = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Press anything to continue. . .");
            Console.ReadKey();//make it avaiable only for ESC
            return new Book(title, author, pages);
        }
    }
}