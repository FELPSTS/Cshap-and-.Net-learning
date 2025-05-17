using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° numero:");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}