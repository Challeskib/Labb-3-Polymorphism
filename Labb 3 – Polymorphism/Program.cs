using System;

namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Geometry objekt;

            objekt = new Circle();
            Console.WriteLine(objekt.Area());

            objekt = new Square();
            Console.WriteLine(objekt.Area());

            objekt = new Rectangle();
            Console.WriteLine(objekt.Area());

        }
    }
}
