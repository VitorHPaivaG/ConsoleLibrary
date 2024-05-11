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

        public Person personRegister()
        {
            //fazer o sistema de validação depois
            bool onCheck = true;

            Console.Write("username: ");
            Username = Console.ReadLine();

            Console.Write("password: ");
            Password = Console.ReadLine();

            return new Person(Username, Password);
            //fazer com que a senha fique ***** quando estiver digitando no console
            //e fazer a pergunta: "Wants to see your password? You can change it if you like: [Y/N]"
        }

    }
}
