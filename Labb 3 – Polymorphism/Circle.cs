using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Circle : Geometry
    {
        public double Radius { get; set; }
        public double π = 3.141;

        public Circle()
        {
            Radius = 5;

        }

        public override double Area()
        {

            return Radius * Radius * π;

        }

    }
}
