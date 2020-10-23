using System;

namespace IMCCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso em kg: ");
            int peso = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = Math.Round(peso / (Math.Pow(altura, 2)), 1);
            Console.WriteLine("Seu imc é igual a :" + imc);
        }
    }
}
