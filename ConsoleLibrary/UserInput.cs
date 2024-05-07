using System;

namespace ConsoleLibrary
{
    class UserInput
    {
        public string UserChoose()
        {
            string choose = string.Empty;
            bool stillChoosing = false;

            while (!stillChoosing)//ok
            {
                Console.WriteLine("1 - Add a new book to the BookShelf.");
                Console.WriteLine("2 - See the list of all the books on the shelf.");
                Console.WriteLine("3 - Close the program.");
                Console.WriteLine("");
                Console.Write("What you want to do?: ");
                choose = Console.ReadLine();

                if (choose == "1")
                {
                    AddingBooks();
                }
                else if (choose == "2")
                {
                    BookDetailsValuePair();
                }
                else if (choose == "3")
                {
                    stillChoosing = true;

                }
                else
                {
                    Console.WriteLine("Invalid Parameter, please try again. . .");
                    Console.ReadKey();
                }
            }

            return choose;
        }

        static Book AddingBooks()//ok
        {
            Console.WriteLine("Please add in this order [TITLE, AUTHOR, PAGES]: ");

            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int pages;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out pages) && pages > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number, Enter a integer number");
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Press anything to continue. . .");
            Console.ReadKey();
            return new Book(title, author, pages);
        }

        public void BookDetailsValuePair()
        {
            Book book = new Book();

            book.BookAuthor();
            Console.WriteLine("");

            Console.WriteLine("Press anything to continue. . .");
            Console.ReadKey();
        }

        //a further details function based on the response above, with title, author, pages, release data, publisher

    }
}
