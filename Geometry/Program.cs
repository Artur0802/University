using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure1 = new Figure(FigureType.Rectangle);
            figure1.CalculatePerimeter();
            Console.ReadLine();
        }
    }
}
