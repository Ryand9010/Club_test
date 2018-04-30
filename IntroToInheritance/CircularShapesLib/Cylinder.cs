using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    // If a class doesn't define a constructor
    // the compiler will provide a default constuctor
    public class Cylinder : Circle
    {
        // define additional private fields that pertain to this class
        // but not to the Parent Class (Circle)
        private double _height;
        // the Cylinder has actually 2 fields: _radius(inhereited), _height

        // constructor
        public Cylinder(double radius, double height) :base(radius)
        {
            _height = height;           
        }

        // property
        public double Height
        { get { return _height; } }

        // Method Hiding: Allow this child to redefine some or all
        // the inherited methods (or properties)

        // since the cylinder is ok with the formula in the Circle perimeter
        // there is no need to redefine it.

        // However, the Cylinder uses different formulas for Area and Volume
        // We should redefine both Area and Volume.
        // Make sure to write the method name exactly as defined in the 
        // parent
        new public double Area()
        {
            double a = 2 * Math.PI * Radius * Height;
            return a;
        }
        
        new public double Volume()
        {
            double v = Math.PI * Radius * Radius * Height;
            return v;
        }
    }
}
