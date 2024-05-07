using System;

namespace ConsoleLibrary
{
    class UserInput
    {
        Book book = new Book();//isso aq tbm ta estranho

        public string UserChoose()
        {
            //arrumar essa joça
            bool onWork = false;
            string choose = string.Empty;

            while (!onWork)
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
                    onWork = true;
                }
            }
            return choose;
        }

        static object AddingBooks()//parece ok 
        {
            Console.WriteLine("Please add in this order [TITLE, AUTHOR, PAGES]: ");
            Book book = new Book(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));//wtf

            Console.ReadKey();
            return book;//a chave (title) n da pra repetir, agora o autor da sim pra repetir
        }

        public void BookDetailsValuePair()//isso aq tbm parece ok
        {
            book.BookAuthor();//ta chamando detalhe do livro local, e nem está adicionando
            Console.ReadKey();
            UserChoose();
        }

    }
}
