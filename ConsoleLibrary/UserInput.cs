using System;
using System.Threading;

namespace ConsoleLibrary
{
    class UserInput
    {
        public void UserInputs()
        {
            bool onWork = false;

            Console.WriteLine("Welcome to the library\n");

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
                    Thread.Sleep(consoleClearTimer);
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
            //ñ sou fã disso
            string title = string.Empty;
            string author = string.Empty;
            string pages = string.Empty;
            bool onCheck = true;
            int clearTime = 500;

            Thread.Sleep(clearTime);
            Console.Clear();

            //finalmente em caralho, porra qnd o cara n ta focado fica foda de programar, negocio facil desse, errando td hora
            while (onCheck)
            {
                Console.Write("Title: ");
                title = Console.ReadLine();

                Console.Write("Author: ");
                author = Console.ReadLine();

                Console.Write("Pages: ");
                pages = Console.ReadLine();

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(pages))
                {
                    Thread.Sleep(clearTime);
                    Console.Clear();
                    Console.WriteLine("All parameters must be filled. Try again.");
                }
                else
                {
                    onCheck = false;
                }
            }

            Console.WriteLine("Press anything to continue. . .");//colocar pra funcionar só no esc
            Console.ReadLine();
            return new Book(title, author, pages);
        }
    }
}