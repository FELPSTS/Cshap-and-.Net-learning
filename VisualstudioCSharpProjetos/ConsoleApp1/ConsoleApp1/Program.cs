using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três numeros:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            double Resultado = Maior(num1, num2, num3);

            Console.WriteLine("Maiot =" + Resultado);

        }
        static int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}