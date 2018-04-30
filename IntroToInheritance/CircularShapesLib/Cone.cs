using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    // Cone should inherit from Cylinder, because both share the same fields:
    // radius and height
    public class Cone: Cylinder
    {
        //constructor
        public Cone(double radius, double height) : base(radius, height) { }

        // methods
        new public double Area()
        {
            double a = Math.PI * Radius * (Radius + Math.Sqrt(Math.Pow(Height,2) + Math.Pow(Radius,2)));
            return a;
        }

        new public double Volume()
        {
            double v = Math.PI * Math.Pow(Radius, 2) * (Height / 3);
            return v;
        }
    }




}
