using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            square.CalculatePerimeter();
            var rectangle = new Rectangle(2, 4);
            rectangle.CalculatePerimeter();
            var triangle = new Triangle(10, 20, 30);
            triangle.CalculatePerimeter();
            Console.ReadLine();
        }
    }
}
