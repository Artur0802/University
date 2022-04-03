using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Figure
    {
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            Name = "square";
            SideLength = sideLength;
        }

        public void CalculatePerimeter()
        {
            Perimeter = SideLength*4;
            base.CalculatePerimeter(Name);
        }
    }
}
