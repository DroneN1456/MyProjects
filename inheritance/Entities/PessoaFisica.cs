using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaanual, double gastosaude) : base (nome, rendaanual)
        {
            GastosSaude = gastosaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15) - (GastosSaude * 0.50);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastosSaude * 0.50);
            }
        }
    }
}
