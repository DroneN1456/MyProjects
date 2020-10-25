using Abstract1.Entities;
using Abstract1.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Abstract1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Shape #" + (i + 1) + " data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string rsp = Console.ReadLine();
                rsp = rsp.ToUpper();
                Console.Write("Color (Black/Blue/red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine().ToUpper());
                if (rsp == "R")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Shape shape = new Rectangle(color, width, height);
                    shapes.Add(shape);
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape shape = new Circle(color, radius);
                    shapes.Add(shape);
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape x in shapes)
            {
                Console.WriteLine(x.Area().ToString("F2"));
            }
            
        }
    }
}
