using System;
using System.Collections.Generic;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Console Library Manager";

            Person person = new Person();

            UserInput user_input = new UserInput();

            person.personRegister();

            user_input.UserInputs();

            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("See you next time, please any key to close the terminal. . .");
            Console.ReadKey();
        }
    }
}




