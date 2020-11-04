using System;
using System.Globalization;
using System.IO;

namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o caminho do arquivo: ");
            string sourcepath = Console.ReadLine();
            string newFolder = Path.GetDirectoryName(sourcepath) + @"\out";
            Directory.CreateDirectory(newFolder);
            string outfile = Path.GetFullPath(newFolder) + @"\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);
                foreach(string line in lines)
                {
                    string[] fields = line.Split(';');
                    string nome = fields[0];
                    double valor = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(fields[2]);
                    Produto produto = new Produto(nome, valor, quantidade);
                    double total = (double)produto.quantidade * produto.valor;
                    using (StreamWriter sr = File.AppendText(outfile))
                    {
                        sr.WriteLine(produto.nome + ";" + total.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
               
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
