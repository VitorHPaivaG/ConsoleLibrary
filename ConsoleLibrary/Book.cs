using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Book
    {
        //static private List<string> bookInfo = new List<string>(); //necessario?
        static private Dictionary<string, string> bookShelf = new Dictionary<string, string>();    

        public string Title {  get; private set; }//uma abordagem melhor?
        public string Author { get; private set; }
        public int Pages { get; private set; }

        public Book() { }
        public Book(string _title, string _author, int _pages)
        {
            Title = _title;
            Author = _author;
            Pages = _pages;

            bookShelf.Add(Title, Author);
            Console.WriteLine("Book added succesfully!");
        }



        public string BookDetails()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPages: {Pages}";
        }


    }
}
