using System;
using System.Collections.Generic;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Console Library Manager";
            Console.WriteLine("Welcome to the library\n");

            UserInput inputs = new UserInput();
            
            inputs.UserChoose();

            

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




