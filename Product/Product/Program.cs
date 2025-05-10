using Product;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Digite os dados do produto");
            Console.WriteLine("Digite o nome do produto");
            p.nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            p.Preco = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto no estoque");
            p.Quatindade = Console.ReadLine();

            Console.WriteLine("Dados do produto: " + p);

            
        }
    } 
}