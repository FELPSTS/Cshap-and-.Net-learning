using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três numeros:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maior = Maior(num1, num2, num3);

            Console.WriteLine($"O maior número é: {maior}");
        }
        static
            int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
    }
}