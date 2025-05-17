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

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area do triangulo A: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo B: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
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