using inheritance.Entities;
using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Tax payer #" + (i + 1) + " data:");
                Console.Write("Individual or company? ");
                string rsp = Console.ReadLine().ToUpper();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double rendaanual = double.Parse(Console.ReadLine());
                if(rsp == "I")
                {
                    Console.Write("Health expenditures: ");
                    double gastossaude = double.Parse(Console.ReadLine());
                    Pessoa pessoa = new PessoaFisica(name, rendaanual, gastossaude);
                    pessoas.Add(pessoa);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    Pessoa pessoa = new PessoaJuridica(name, rendaanual, funcionarios);
                    pessoas.Add(pessoa);
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Pessoa x in pessoas)
            {
                Console.WriteLine(x);
            }
        }
    }
}
