using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine());

                while (x >= 0.0)
                {
                    double raiz = Math.Sqrt(x);
                    Console.WriteLine($"A raiz quadrada de {x} é {raiz}");
                    Console.WriteLine("Digite outro número: ");
                    x = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("Número negativo, fim do programa.");
        }
    }
}