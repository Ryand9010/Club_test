using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Box : Rectangle
    {
        // Contructor
        public Box(double l, double w, double h) : base(l,w,h) { }

        // Methods
        public override double Area()
        {
            double area = (2 * (H * W)) + (2 * (H * L)) + (2 * (W * L));
            return area;
        }
        

    }
}
