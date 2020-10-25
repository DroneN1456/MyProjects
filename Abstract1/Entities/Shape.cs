using Abstract1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract1.Entities
{
    abstract class Shape
    {
        Color Color;

        public Shape(Color color)
        {
            Color = color;
        }

        public virtual double Area()
        {
            return 0;
        }
    }
}
