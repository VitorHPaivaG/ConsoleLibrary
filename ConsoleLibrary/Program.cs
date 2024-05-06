using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Console Library Manager";
            Console.WriteLine("Welcome to the library");

            Console.WriteLine("What you want to do?\n");

            Book book = new Book("The screwtappes letters", "C.S Lewis", 206);

            Console.WriteLine(book.BookDetails());


            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to close the terminal");
            Console.ReadKey();
        }
    }
}
