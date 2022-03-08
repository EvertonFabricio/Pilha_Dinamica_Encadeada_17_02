using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Encadeada
{
    internal class Livro
    {
        //prop tab tab escreve a propriedade e eu só renomeio o atributo.
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Anterior { get; set; }


        public Livro(string titulo, int anoPublicacao, string iSBN)
        {
            ISBN = iSBN;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Anterior = null;
        }


        public override string ToString()
        {
            return $"\n***DADOS DO LIVRO***\nTitulo: {Titulo}\nPublicação: {AnoPublicacao}\nISBN: {ISBN}";

        }
    }
}

