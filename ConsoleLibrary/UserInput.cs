using System;
using System.Threading;

//ideias fodas

/*Claro, aqui estão algumas sugestões de recursos adicionais que você pode considerar para expandir o seu programa de 
 * gerenciamento de biblioteca:

    Banco de dados: Integre um banco de dados para armazenar informações dos livros de forma persistente. Isso permitirá 
que os dados sejam mantidos entre diferentes execuções do programa e fornecerá capacidades de pesquisa e organização mais 
avançadas. //da pra fazer, quando eu descobrir como conectar banco de dados no vs (e nn o code)

    Sistema de busca: Implemente um sistema de busca para permitir que os usuários encontrem livros com base em diferentes 
critérios, como título, autor, gênero, etc. //da pra fazer

    Sistema de empréstimo: Adicione a funcionalidade de empréstimo de livros, onde os usuários podem registrar quem está 
atualmente com o livro emprestado e quando ele deve ser devolvido. //da pra fazer

    Avaliações e comentários: Permita que os usuários classifiquem e deixem comentários sobre os livros que leram, 
criando assim uma comunidade em torno da sua biblioteca. //até q da, só que nesse contexto parece besta
 
    Notificações: Implemente um sistema de notificação para lembrar os usuários sobre datas de devolução de livros
emprestados, novos lançamentos, etc. //sem sentido, visto que é algo de console

    Estatísticas e relatórios: Forneça aos usuários e administradores a capacidade de visualizar estatísticas sobre 
os livros mais populares, tendências de leitura, etc. //da pra fazer, mas, parece um pouco mais complicadinho

    Importação e exportação de dados: Permita que os usuários importem e exportem dados de livros em vários formatos,
como CSV, JSON, etc., para facilitar a migração de dados e integração com outros sistemas. //legal, só que nesse contexto n da certo

    Integração com APIs de terceiros: Integre sua aplicação com APIs de serviços externos, como Goodreads ou Google 
Books, para obter informações adicionais sobre os livros, capas, resenhas, etc. //muito legal, se tivesse uma interface propria

    Interface gráfica do usuário (GUI): Se quiser tornar sua aplicação mais amigável, considere criar uma interface 
gráfica do usuário em vez de apenas uma interface de console.*/ //basicamente, resolve o problema de algumas features acima

namespace ConsoleLibrary
{
    class UserInput
    {
        public void UserInputs()
        {
            bool onWork = true;

            Console.WriteLine("Welcome to the library\n");

            while (onWork)
            {
                int consoleClearTimer = 1000;

                Console.WriteLine("==============================================");
                Console.WriteLine("1 - See all the books listed in the bookshelf.");
                Console.WriteLine("2 - Add a new book into the bookshelf.");
                Console.WriteLine("3 - Close the program.");
                Console.WriteLine("==============================================");

                string choose = Console.ReadLine();

                //jogar tudo isso fora, e deixar os ifs para retornarem direito na classe Books, parece melhor pra evitar
                //dor de cabeça

                if (choose == "1")
                {
                    ListedBooksBookshelf();
                }
                else if (choose == "2")
                {
                    Adding_Book();
                    Thread.Sleep(consoleClearTimer);
                    Console.Clear();
                }
                else if (choose == "3")//Close the program
                {
                    onWork = false;
                    EndProgram();
                }
                else
                {
                    Console.WriteLine("Wrong parameter, try again.");
                    Console.WriteLine("");
                }
            }
        }

        //se pá seria mais jogo separar tudo isso em outras classes separadas, junto com sistema de avaliação e todo o resto
        static void ListedBooksBookshelf()//See all the books listed in the bookshelf
        {
            Book book = new Book();
            book.BookValuePair();

            Console.WriteLine("Press anything to continue. . .");
            Console.ReadKey();
        }
        public Book Adding_Book()//Add a new book into the bookshelf
        {
            //ñ sou fã disso
            string title = string.Empty;
            string author = string.Empty;
            string pages = string.Empty;
            bool onCheck = true;
            int clearTime = 500;

            Thread.Sleep(clearTime);
            Console.Clear();

            while (onCheck)
            {
                Console.Write("Title: ");
                title = Console.ReadLine();

                Console.Write("Author: ");
                author = Console.ReadLine();

                Console.Write("Pages: ");
                pages = Console.ReadLine();

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(pages))
                {
                    Thread.Sleep(clearTime);
                    Console.Clear();
                    Console.WriteLine("All parameters must be filled. Try again.");
                }
                else
                {
                    onCheck = false;
                }
            }

            Console.WriteLine("Press anything to continue. . .");//colocar pra funcionar só no esc
            Console.ReadLine();
            return new Book(title, author, pages);
        }
        static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("See you next time, please any key to close the terminal. . .");
            Console.ReadKey();
        }
    }
}