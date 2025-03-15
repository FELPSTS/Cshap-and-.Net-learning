// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 255;

            n1++;

            Console.WriteLine(n1);

            if (n1 == 0) 
            {
                Console.WriteLine("passou do limite de byts");
                    } ;
        }
    }
}