using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] vec1 = Console.ReadLine().Split(' ');
            int x = int.Parse(vec1[0]);
            int y = int.Parse(vec1[1]);
            int[,] mat = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                string[] vec2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(vec2[j]);
                }
            }
            int searchNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == searchNumber)
                    {
                        Console.WriteLine("Position : " + i + ", " + j);
                       if (j > 0)
                        {
                            Console.WriteLine("Left : " + mat[i, j - 1]);
                        }
                       if (i > 0)
                        {
                            Console.WriteLine("Up : " + mat[i - 1, j]);
                        }
                       if (j < y - 1)
                        {
                            Console.WriteLine("Right : " + mat[i, j + 1]);
                        }
                       if (i < x - 1)
                        {
                            Console.WriteLine("Down : " + mat[i + 1, j]);
                        }
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
