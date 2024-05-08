using System;

namespace ConsoleLibrary
{
    class UserInput
    {
        Book book = new Book();//dont like this
        public void UserChoose()
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
                else if (choose == "4")
                {
                    RentingBooks();
                }
                else
                {
                    Console.WriteLine("Invalid Parameter, please try again. . .");
                    Console.ReadKey();
                }
            }
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

            book.BookAuthor();
            Console.WriteLine("");

            Console.WriteLine("Press anything to continue. . .");
            Console.ReadKey();
        }

        public string RentingBooks()//idk what to do, maybe its better to put everything on the trash and try again
        {
            Book book = new Book();
            foreach (var bookCollection in book.bookShelf)
            {
                Console.WriteLine($"Title: {book.Title}\nAuthor: {book.Author}");
            }

            Console.WriteLine("");

            Console.Write("Which one you want to rent?: [TITLE]");
            string rentedBook = Console.ReadLine();

            return rentedBook;
        }

        //a further details function based on the response above, with title, author, pages, release data, publisher
    }
}

//renting a book/s
//the idea is to see if the book searched (search class?) and return if its avaiable or not, or its not yet on the shelf
//return how many time you gonna stay with the rented book