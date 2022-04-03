using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : Figure
    {
        public int ShortSideLength { get; set; }
        public int LongSideLength { get; set; }

        public Rectangle(int shortSideLength, int longSideLength)
        {
            Name = "rectangle";
            ShortSideLength = shortSideLength;
            LongSideLength = longSideLength;
        }

        public void CalculatePerimeter()
        {
            Perimeter = ShortSideLength * 2 + LongSideLength * 2;
            base.CalculatePerimeter(Name);
        }
    }
}
