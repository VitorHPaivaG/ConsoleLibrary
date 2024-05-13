using System;
using System.Collections.Generic;
using System.Threading;

//Gestão de usuários: Crie um sistema de gerenciamento de usuários, onde os usuários podem se registrar, fazer login e
//gerenciar suas próprias listas de livros, favoritos, histórico de empréstimos, etc.

namespace ConsoleLibrary
{
    class Person
    {
        static private Dictionary<string, string> PersonLogin = new Dictionary<string, string>();//meh o nome

        public string Username { get; set; }
        public string Password { get; set; }


        public Person() { }
        public Person(string _username, string _password)
        {
            Username = _username;
            Password = _password;

            Console.WriteLine("Register completed.");
            PersonLogin.Add(Username, Password);
            Thread.Sleep(800);
            Console.Clear();
        }

        public Person PersonRegister()
        {
            //fazer o sistema de validação depois
            bool onCheck = true;
            int clearingConsole = 1000;

            while (onCheck)
            {
                Thread.Sleep(clearingConsole);
                Console.Clear();

                Console.Write("Enter your username: ");
                Username = Console.ReadLine();

                Console.Write("Enter your password: ");
                Password = Console.ReadLine();


                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    Console.WriteLine("Username and password must be filled. Try again.");
                }
                else if (Username.Length > 20 || Username.Length < 8)
                {
                    Console.WriteLine("Username length must be between 8 to 20 chars long.");//se acontece esse, o de baixo n acontece
                }
                else if (Password.Length > 20 || Password.Length < 10)
                {
                    Console.WriteLine("Password length must be between 10 to 20 chars long.");
                }
                else
                {
                    onCheck = false;
                }
            }

            return new Person(Username, Password);
            //fazer com que a senha fique ***** quando estiver digitando no console
        }

    }
}
