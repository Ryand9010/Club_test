using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Square : Rectangle
    {
        // Constructor
        public Square(double l) : base(l, 0, 0) { }

        // Methods
        public override double Area()
        {
            double area = Math.Pow(L, 2);
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 4 * L;
            return perimeter;
        }

    }
}
