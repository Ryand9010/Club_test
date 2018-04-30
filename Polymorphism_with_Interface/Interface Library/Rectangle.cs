using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Library
{
    public class Rectangle : IShape
    {
        // Fields
        private double l; // length
        private double w; // width

        // Constructor
        public Rectangle(double length, double width)
        {
            l = length;
            w = width;
        }

        // Properties
        public double L { get { return l; } }
        public double W { get { return w; } }

        // Methods
        public double Area()
        {
            return l * w;
        }

        public double Perimeter()
        {
            return 2 * (l + w);
        }

        public double Volume()
        {
            return 0;
        }
    }
}
