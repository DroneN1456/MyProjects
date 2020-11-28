using System;
using System.IO;
using System.Collections.Generic;

namespace dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> register = new Dictionary<string, int>();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(';');
                        string name = fields[0];
                        int votes = int.Parse(fields[1]);
                        if(!register.ContainsKey(name))
                        {
                            register[name] = votes;
                        }
                        else
                        {
                            register[name] = register[name] + votes;
                        }
                    }
                }
                foreach(var a in register)
                {
                    Console.WriteLine(a.Key + ": " + a.Value);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
