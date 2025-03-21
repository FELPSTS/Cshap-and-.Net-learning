using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean c1= 2 > 3 && 4 != 5;
            Boolean c2 = 2 > 3 || 4 != 5;
            Boolean c3 = !(2 > 3) && 4 != 5;


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("-----------------");

            Boolean c4 = 10 < 5;
            Boolean c5 = c1 || c2 && c3;

            Console.WriteLine(c4);
            Console.WriteLine(c5);

        }
    }
}