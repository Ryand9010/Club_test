using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public class Cylinder : CircularShape
    {
        // constructor
        public Cylinder(double r, double h) : base(r, h) { }


        // MUST override volume since it was declared
        // abstract in the parent class
        public override double Volume()
        {
            double v = Math.PI * R * R * H;
            return v;
        }

        // MAY override Area. Only if implementation is
        // different
        public override double Area()
        {
            double a = 2 * Math.PI * R * H;
            return a;
        }

    }
    //Exercise: Complete this project
    // Turn the Rectanglular shapes project by making
    // base class abstract.
}
