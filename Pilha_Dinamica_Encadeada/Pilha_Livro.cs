using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Encadeada
{
    internal class Pilha_Livro
    {

        public Livro Topo { get; set; }

        public Pilha_Livro()
        {
            Topo = null;
        }

        public int cont = 0;
        public bool vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }

        public void push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
            Console.WriteLine("Livro inserido com sucesso!\n\nPressione ENTER para prosseguir.");
            Console.ReadKey();
            Console.Clear();
            cont++;
        }

        public void pop()
        {
            if (vazia())
                Console.WriteLine("A pilha está vazia.\n\nPressione ENTER para prosseguir.");
            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("O livro foi removido.\n\nPressione ENTER para prosseguir.");
                cont--;
            }
            Console.ReadKey();
            Console.Clear();
        }


        public void print()
        {
            if (vazia())
                Console.WriteLine("A pilha está vazia");
            else
            {
                Console.WriteLine("os livros da pilha são:");
                Livro aux = Topo;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                    Console.WriteLine("\nPressione ENTER para ver o próximo.");
                    Console.ReadKey();
                    Console.Clear();
                }
                while (aux != null);
                Console.WriteLine("\nFim da impressão");
            }
            Console.WriteLine("\nPressione ENTER para prosseguir.");
            Console.ReadKey();
            Console.Clear();
        }

        public void buscar()
        {
            if (vazia())
                Console.WriteLine("Não existem livros cadastrados.");


            else
            {
                Console.WriteLine("Digite o nome do livro ou seu ISBN para realizar a busca: ");
                string busca = Console.ReadLine();
                Livro aux = Topo;
                Console.Clear();
                do
                {
                    if (busca == aux.Titulo || busca == aux.ISBN)
                    {
                        Console.WriteLine(aux.ToString());
                        aux = aux.Anterior;
                    }
                    else
                    {
                        Console.WriteLine("Sua busca não encontrou resultados.");
                    }
                    break;
                }
                while (aux != null);
            }
            Console.WriteLine("\nPressione ENTER para prosseguir.");
            Console.ReadKey();
            Console.Clear();

        }

        public void contar()
        {
            if (cont == 0)
            {
                Console.WriteLine("Não existem livros cadastrados.");
                Console.WriteLine("\nPressione ENTER para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            { 
                Console.WriteLine($"Você tem {cont} livro(s) cadastrado(s).");
                Console.WriteLine("\nPressione ENTER para prosseguir.");
                Console.ReadKey();
                Console.Clear();
            }
        }


    }
}
