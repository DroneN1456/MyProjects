using set1.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace set1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<log> logs = new HashSet<log>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(path);
            foreach (string a in lines)
            {
                string[] fields = a.Split(' ');
                string user = fields[0];
                DateTime logDate = DateTime.Parse(fields[1]);
                logs.Add(new log(user, logDate));
            }
            Console.WriteLine("Total users: " + logs.Count);

        }
    }
}
