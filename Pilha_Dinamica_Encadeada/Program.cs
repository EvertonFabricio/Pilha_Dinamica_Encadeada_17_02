using System;

namespace Pilha_Dinamica_Encadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha_Livro pilha = new Pilha_Livro();
            

            int ano;
            string nome, isbn;

            Console.WriteLine("*-*-*Bem vindo a Pilha de Livros!*=*=*");
            do
            {
                Console.WriteLine("\nDigite a opção desejada:\n");
                Console.WriteLine("1 - Cadastrar Livros.");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Imprimir Relação de Livros");
                Console.WriteLine("4 - Ver quantidade cadastrada");
                Console.WriteLine("5 - Buscar um Livro");
                Console.WriteLine("0 - Sair");
                Console.Write("\nOpção: ");
                int menu = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 0:
                        Console.WriteLine("O programa foi encerrado.");
                        break;

                    case 1://inserir
                        inserir(out ano, out isbn, out nome);
                        pilha.push(new Livro(nome, ano, isbn));
                        break;

                    case 2://remover
                        pilha.pop();
                        break;

                    case 3://imprimir um de cada vez
                        pilha.print();
                        break;

                    case 4://recuperar a quantidade.
                        pilha.contar();
                        break;

                    case 5://buscar
                        pilha.buscar();                                           
                        break;

                    default:
                        Console.WriteLine("\nOpção incorreta. Tente novamente.");
                        break;
                }
                if (menu == 0)
                    break;
            }
            while (true);
        }

        private static void inserir(out int ano, out string isbn, out string nome)
        {
            Console.Write("Informe o nome do livro: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.Write("Informe o ano em que foi publicado: ");
            ano = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe seu ISBN: ");
            isbn = Console.ReadLine();
            Console.Clear();
        }
    }

}

