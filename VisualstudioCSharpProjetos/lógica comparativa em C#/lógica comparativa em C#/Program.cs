using System;
using System.Reflection.Metadata;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Boolean c1 = a < 10;
            Boolean c2 = a < 20;
            Boolean c3 = a > 10;
            Boolean c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(" ----------------- ");

            Boolean c5 = a <= 10;
            Boolean c6 = a >= 10;
            Boolean c7 = a == 10;
            Boolean c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}