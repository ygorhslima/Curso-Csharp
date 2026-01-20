/*
    o problema consiste em elaborar um cadastro de 20 livros, contendo as seguintes informações: código, título, autor, ano e editora. Desenvolver um menu com as seguintes opções

    1. Cadastrar os livros
    2. Imprimir as informações dos livros
    3. Pesquisar livros por código
    4. Ordenar os livros por ano
    5. Sair do programa
*/

using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace ExFinal
{
    class Livro
    {
        public int Codigo {get;set;}
        public string Titulo {get;set;}
        public string Autor {get;set;}
        public string Area {get;set;}
        public int Ano {get;set;}
        public string Editora {get;set;}
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Livro[] Acervo = new Livro[2];

            int op;
            op = 0;
            while(op != 5)
            {
                Console.WriteLine("----------- GERENCIADOR DE LIVROS ------------");
                Console.WriteLine("1 - Cadastrar os livros");
                Console.WriteLine("2 - Imprimir as informações dos livros");
                Console.WriteLine("3 - Pesquisar livros por código");
                Console.WriteLine("4 - Ordenar os livros por ano");
                Console.WriteLine("5 - Sair do programa");

                Console.Write("Digite a opção desejada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CadastrarLivros(Acervo);
                        break;
                    case 2:
                        ImprimirLivros(Acervo);
                        break;
                    case 3:
                        PesquisarLivros(Acervo);
                        break;
                    case 4:
                        OrdenarLivros(Acervo);
                        break;
                    case 5:
                        Console.WriteLine("saindo do programa");
                        break;
                    default:
                        Console.WriteLine("Digite a opção correta");
                        break;
                }
            }
        }

        public static void CadastrarLivros(Livro[] lista)
        {
            for(int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"------Cadastro do livro {i+1}------");

                lista[i] = new Livro();
                
                Console.Write("Código: ");
                lista[i].Codigo = int.Parse(Console.ReadLine());

                Console.Write("Título: ");
                lista[i].Titulo = Console.ReadLine();

                Console.Write("Autor: ");
                lista[i].Autor = Console.ReadLine();

                Console.Write("Area: ");
                lista[i].Area = Console.ReadLine();

                Console.Write("Ano: ");
                lista[i].Ano = int.Parse(Console.ReadLine());

                Console.Write("Editora: ");
                lista[i].Editora = Console.ReadLine();
            }
        }
        
        public static void ImprimirLivros(Livro[] lista)
        {
            if(lista[0] == null)
            {
                Console.WriteLine("O acervo está vazio! cadastre os livros primeiro");
                return;
            }
            for(int i = 0; i< lista.Length; i++)
            {
                Console.WriteLine($"------- Livro {i+1} -------");
                Console.WriteLine($"Código..: {lista[i].Codigo}");
                Console.WriteLine($"Titulo..: {lista[i].Titulo}");
                Console.WriteLine($"Autor...: {lista[i].Autor}");
                Console.WriteLine($"Area....: {lista[i].Area}");
                Console.WriteLine($"Ano.....: {lista[i].Ano}");
                Console.WriteLine($"Editora.: {lista[i].Editora}");
            }
        }

        public static void PesquisarLivros(Livro[] lista)
        {
            Console.Write("Digite o código do livro para pesquisar: ");
            int busca = int.Parse(Console.ReadLine());

            var livroEncontrado = lista.FirstOrDefault(l => l != null && l.Codigo == busca);

            if(livroEncontrado != null)
            {
                Console.WriteLine("livro encontrado");
                Console.WriteLine($"Título: {livroEncontrado.Titulo}\nAutor: {livroEncontrado.Autor}");
            }
            else
            {
                Console.WriteLine($"livro com código {busca} não encontrado");
            }

        }
        public static void OrdenarLivros(Livro[] lista)
        {
            if (lista.Any(l => l == null))
            {
                Console.WriteLine("Atenção: Cadastre todos os livros antes de ordenar");
                return;
            }
            Array.Sort(lista, (x,y)=>x.Ano.CompareTo(y.Ano));
            Console.WriteLine("Acervo ordenado por ano com sucesso!");
        }
    }
}