using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Rectangle : Geometry
    {

        public double Length;

        public Rectangle()
        {
            Length = 4.24499705536;
        }
        public override double Area()
        {

            return Length * Length;
        }


    }
}
