using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapeLib
{
    public class Cone : Cylinder
    {
        // constructor
        public Cone(double r, double h) : base(r, h)
        {

        }

        // methods
        public override double Area()
        {
            double a = Math.PI * R * (R + Math.Sqrt(Math.Pow(H, 2) + Math.Pow(R, 2)));
            return a;
        }

        public override double Volume()
        {
            double v = Math.PI * Math.Pow(R, 2) * (H / 3);
            return v;
        }
        
    }
}
