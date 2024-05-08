using System;
using System.Collections.Generic;

namespace ConsoleLibrary
{
    class Book
    {
        //static private List<string> bookInfo = new List<string>(); //necessario?
        public Dictionary<string, string> bookShelf = new Dictionary<string, string>();

        public string Title { get; set; }//private set?
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book() { }
        public Book(string _title, string _author, int _pages)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;

            bookShelf.Add(Title, Author);
            Console.WriteLine("Book added succesfully!");
        }

        public void BookAuthor()//return all books with their author name and the title itself
        {
            foreach (KeyValuePair<string, string> book in bookShelf)
            {
                Console.WriteLine($"* {book.Key} - {book.Value}.");
            }
        }




        /* public string BookDetails()//return details of an specific book
        {
            return $"Title: {Title}\nAuthor: {Author}\nPages: {Pages}";
        }
        
        getting rid of this for now, do something better later
         */


    }
}
