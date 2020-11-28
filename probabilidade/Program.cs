using System;
using System.Collections.Generic;
using Entities;

namespace probabilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("João", 20, 'M'));
            people.Add(new Person("Marcelo", 24, 'M'));
            people.Add(new Person("Rafael", 19, 'M'));
            people.Add(new Person("Guilherme", 23, 'M'));
            people.Add(new Person("Pedro", 30, 'M'));
            people.Add(new Person("Luis", 20, 'M'));
            people.Add(new Person("Gustavo", 19, 'M'));
            people.Add(new Person("Thiago", 20, 'M'));
            people.Add(new Person("Maria", 24, 'F'));
            people.Add(new Person("Lorena", 19, 'F'));
            people.Add(new Person("Karyn", 22, 'F'));
            people.Add(new Person("Vitoria", 20, 'F'));
            people.Add(new Person("Isadora", 28, 'F'));
            people.Add(new Person("Julia", 26, 'F'));
            people.Add(new Person("Bianca", 35, 'F'));
            people.Add(new Person("Yasmin", 23, 'F'));
            people.Add(new Person("Livia", 45, 'F'));
            people.Add(new Person("Nicoly", 44, 'F'));
            people.Add(new Person("Maju", 43, 'F'));
            people.Add(new Person("Manuela", 42, 'F'));
            people.Add(new Person("Laura", 41, 'F'));

            Predicate<Person> predicate = (a) => a.idade > 40 && a.sexo == 'F';
            
            List<Person> mais40 = people.FindAll(predicate);

            Console.WriteLine("Todas as pessoas: ");

            foreach(Person a in people)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            Console.WriteLine("Mulheres com mais de 40: ");

            foreach(Person a in mais40)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            double probabilidade = ((double)mais40.Count / people.Count) * 100;
            Console.WriteLine("Probabilidade : " + probabilidade.ToString("F2") + "%");



        }
    }
}
