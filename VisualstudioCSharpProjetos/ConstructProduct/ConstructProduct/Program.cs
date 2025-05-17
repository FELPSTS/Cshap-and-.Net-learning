using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite os dados do produto");

            Console.Write("Nome: ");
            String.nome = Console.ReadLine();

            Console.Write("Preço: ");
            double.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int.quantidade = int.Parse(Console.ReadLine());

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