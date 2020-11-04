using System;
using System.Collections.Generic;
using System.Text;

namespace file1
{
    class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;

        public Produto(string nome, double valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }
    }
}
