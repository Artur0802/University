using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Figure
    {
        public int FirstSideLenght { get; set; }
        public int SecondSideLenght { get; set; }
        public int ThirdSideLenght { get; set; }

        public Triangle(int firstSideLenght, int secondSideLenght, int thirdSideLenght)
        {
            Name = "triangle";
            FirstSideLenght = firstSideLenght;
            SecondSideLenght = secondSideLenght;
            ThirdSideLenght = thirdSideLenght;
        }
        public void CalculatePerimeter()
        {
            Perimeter = FirstSideLenght + SecondSideLenght + ThirdSideLenght;
            base.CalculatePerimeter(Name);
        }
    }
}
