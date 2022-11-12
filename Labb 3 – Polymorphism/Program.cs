using System;

namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Geometry Circle = new Circle();
            Console.WriteLine(Circle.Area());

            Geometry Square = new Square();
            Console.WriteLine(Square.Area());

            Geometry Rectangle = new Rectangle();
            Console.WriteLine(Rectangle.Area());

        }
    }
}
