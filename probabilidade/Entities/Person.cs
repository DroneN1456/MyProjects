using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Person
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        public Person(string nome, int idade, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            return nome + ", " + idade + " Anos" + ", " + sexo;
        }
    }
}
