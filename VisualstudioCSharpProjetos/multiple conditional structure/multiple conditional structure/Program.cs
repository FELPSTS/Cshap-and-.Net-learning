﻿using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora >= 0 && hora < 12)
                Console.WriteLine("Bom dia!");
            else if (hora >= 12 && hora < 18)
                Console.WriteLine("Boa tarde!");
            else if (hora >= 18 && hora < 24)
                Console.WriteLine("Boa noite!");
            else
                Console.WriteLine("Hora inválida!");
        }
    }
}