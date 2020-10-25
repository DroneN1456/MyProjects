using Abstract1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (Color color, double radius) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * (Radius * Radius), 2);
        }
    }
}
