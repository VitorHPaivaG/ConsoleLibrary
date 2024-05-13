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

            person.PersonRegister();

            user_input.UserInputs();
        }       
    }
}




