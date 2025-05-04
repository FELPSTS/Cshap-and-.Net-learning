using System;
using System.Globalization;
using triangle;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os valores do triangulo A");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os valores do triangulo B");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaA = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaB = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area do triangulo A: " + areaA.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo B: " + areaB.ToString("F4", CultureInfo.InvariantCulture));

            if (areaA > areaB)
            {
                Console.WriteLine("O triangulo A tem a maior area");
            }
            else
            {
                Console.WriteLine("O triangulo B tem a maior area");
            }
        }
    }
}