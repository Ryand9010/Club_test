using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Rectangle : RectangularShape
    {
        // constructor
        public Rectangle(double l, double w, double h) : base(l, w, h) { }

        // Method
        public override double Volume()
        {
            return 0;
        }
    }
}
