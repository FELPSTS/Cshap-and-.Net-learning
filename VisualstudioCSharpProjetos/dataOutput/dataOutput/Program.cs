using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "PHILIPE";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual á {2:f2} reais", nome,idade,saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual há {saldo:f2} reais");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual há " + saldo.ToString("F2", CultureInfo.InvariantCulture)+ " reais ");
        }
    }
}