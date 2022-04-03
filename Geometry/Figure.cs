using System;

namespace Geometry
{
    public abstract class Figure
    {
        protected string Name { get; set; }
        protected int Perimeter { get; set; }

        public void CalculatePerimeter(string figureName)
        {
            Console.WriteLine("Perimeter of the {0} is {1}.", figureName, Perimeter);
        }
    }
}
