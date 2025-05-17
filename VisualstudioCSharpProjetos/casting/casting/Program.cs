using System;
using System.Data;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double e = c / d;

            Console.WriteLine(e);

            int _c = 5;
            int _d = 2;

            double _e = (double) _c / _d;

            Console.WriteLine(_e);

        }
    }
}