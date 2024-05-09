using System;
using System.Collections.Generic;

namespace ConsoleLibrary
{
    class Book
    {
        //static private List<string> bookInfo = new List<string>(); //necessario?
        static public Dictionary<string, string> bookShelf = new Dictionary<string, string>();

        public string Title { get; set; }//private set?
        public string Author { get; set; }
        public string Pages { get; set; }
        //realmente vale a pena deixar como int? Meio que fodasse eu acho
        //vou deixar como string por enquanto e ver oq se sai melhor

        public Book() { }
        public Book(string _title, string _author, string _pages)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;

            bookShelf.Add(Title, Author);
            Console.WriteLine("Book added succesfully!");
            Console.WriteLine("");
        }

        public void BookValuePair()//return all books with their author name and the title itself
        {
            Console.WriteLine($"Currently we have {bookShelf.Count} books on the BookShelf");

            foreach (KeyValuePair<string, string> book in bookShelf)
            {
                Console.WriteLine($"* {book.Key} - {book.Value}.");
            }
        }
    }
}
