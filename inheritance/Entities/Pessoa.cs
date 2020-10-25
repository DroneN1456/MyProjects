using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa(string nome, double rendaanual)
        {
            Nome = nome;
            RendaAnual = rendaanual;
        }

        public virtual double Imposto()
        {
            return 0;
        }

        public override string ToString()
        {
            return Nome + ": $ " + Imposto().ToString("F2");
        }
    }
}
