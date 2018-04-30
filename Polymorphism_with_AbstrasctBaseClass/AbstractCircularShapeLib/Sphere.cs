using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public class Sphere : Circle
    {
        public Sphere(double r) : base(r) { }

        
        public override double Area()
        {
            double a = 4 * Math.PI * R * R;
            return a;
        }

        // Since the parent of this class (the circle)
        // did override the Volume, the system would not 
        // impose a must override on the Sphere,
        // but if needed, you should override it if
        // the implementations are different
        public override double Volume()
        {
            double v = 4D / 3D * Math.PI * Math.Pow(R, 3);
            return v;
        }

    }
}
