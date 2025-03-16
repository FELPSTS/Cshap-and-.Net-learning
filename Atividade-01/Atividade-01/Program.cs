using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é{preco1}");
            Console.WriteLine($"{produto2},cujo o preco é R${preco2:f2}");

            Console.WriteLine($"Registro:{idade} anos de idade, codigo {codigo} e gênero{genero}");

            Console.WriteLine($"Medida com oito casas decimais:{medida:f8}");
            Console.WriteLine($"Arredondando (três casas decimais):{medida:f3}");
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}