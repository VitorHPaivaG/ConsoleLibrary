using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleLibrary
{
    class UserInput
    {
        public void UserInputs()
        {
            bool onWork = false;

            while (!onWork)
            {
                int consoleClearTimer = 1000;

                Console.WriteLine("==============================================");
                Console.WriteLine("1 - See all the books listed in the bookshelf.");
                Console.WriteLine("2 - Add a new book into the bookshelf.");
                Console.WriteLine("3 - Close the program.");
                Console.WriteLine("==============================================");

                string choose = Console.ReadLine();
                //jogar tudo isso fora, e deixar os ifs para retornarem direito na classe Books, parece melhor pra evitar
                //dor de cabeça

                if (choose == "1")
                {
                    ListedBooksBookshelf();
                }
                else if (choose == "2")
                {
                    Adding_Book();
                    consoleClearTimer = 1000;//idk how to fix, its attribuited, but needs to pass a value again to work
                    Console.Clear();
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
            book.BookValuePair();

            Console.WriteLine("Press anything to continue. . .");
            Console.ReadKey();
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