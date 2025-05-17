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

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a serem adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a serem removidos: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
