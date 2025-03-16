// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'f';
            byte n1 = 255;

            n1++;

            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(completo);

            float n5 = 4.5f;
            double n6 = 4.5;

            Console.WriteLine($"Esses são os exemplos n5: {n5} e n6: {n6}, assim entendemos a utilização do dounle e do float, e seus limites de byte no .net");

            if (n1 == 0) 
            {
                Console.WriteLine("passou do limite de byts");
                    } ;
        }
    }
}