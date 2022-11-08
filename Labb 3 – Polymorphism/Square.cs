using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Square : Geometry
    {
        public int Length;

        public Square()
        {
            Length = 6;

        }


        public override double Area()
        {
            return Length * Length;
        }

    }
}
