using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Sphere : Circle
    {


        // Constructor
        public Sphere(double radius) : base(radius) { }

        // Methods
        new public double Area()
        {
            double a = 4 * Math.PI * Radius * Radius;
            return a;
        }
       
        new public double Volume()
        {
            double v = 4D / 3D * Math.PI * Math.Pow(Radius, 3);
            return v;
        }
        

        
    }
}
