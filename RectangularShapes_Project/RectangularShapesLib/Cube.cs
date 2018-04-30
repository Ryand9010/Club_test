using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Cube : Square
    {
        // Constructor
        public Cube(double l) : base(l) { }

        // Methods
        public override double Area()
        {
            double area = 6 * (Math.Pow(L, 2));
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 12 * L;
            return perimeter;
        }
        public override double Volume()
        {
            double volume = Math.Pow(L, 3);
            return volume;
        }

    }
}
