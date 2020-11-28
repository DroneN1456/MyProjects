using System;
using System.Collections.Generic;
using set2.Entities;

namespace set2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<User> CourseA = new HashSet<User>();
            HashSet<User> CourseB = new HashSet<User>();
            HashSet<User> CourseC = new HashSet<User>();
            HashSet<User> TotalUsers = new HashSet<User>();
            Console.Write("How many students for course A? " );
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i< N; i++)
            {
                CourseA.Add(new User(int.Parse(Console.ReadLine())));
            }
            Console.Write("How many students for course B? ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                CourseB.Add(new User(int.Parse(Console.ReadLine())));
            }
            Console.Write("How many students for course C? ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                CourseC.Add(new User(int.Parse(Console.ReadLine())));
            }

            TotalUsers.UnionWith(CourseA);
            TotalUsers.UnionWith(CourseB);
            TotalUsers.UnionWith(CourseC);
            Console.WriteLine("Total students: " + TotalUsers.Count);




        }

       
    }
}
