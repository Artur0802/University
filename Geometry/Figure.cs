using System;

namespace Geometry
{
    public class Figure
    {
        public int Perimeter { get; set; }
        public FigureType FigureType { get; set; }
        public int SidesCount { get; set; }
        public int[] SidesLength { get; set; }

        public Figure(FigureType figureType)
        {
            FigureType = figureType;
            DefineSidesCount(figureType);
            DefineSidesLength(SidesCount);
        }

        public void CalculatePerimeter()
        {
            foreach (var length in SidesLength)
            {
                Perimeter = Perimeter + length;
            }
            Console.WriteLine("Perimeter of the figure is {0}", Perimeter);
        }

        private void DefineSidesLength(int sidesCount)
        {
            SidesLength = new int[SidesCount];
            Random random = new Random();
            for (int i = 0; i < SidesCount; i++)
            {
                SidesLength[i] = random.Next(1, 20);
            }
        }

        private void DefineSidesCount(FigureType figureType)
        {
            switch (figureType)
            {
                case FigureType.Square:                    
                    break;
                case FigureType.Rectangle:
                    SidesCount = 4;
                    break;
                case FigureType.Triangle:
                    SidesCount = 3;
                    break;
            }
        }
    }
}
