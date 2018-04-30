using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public  abstract class RectangularShape
    {
        // Fields
        private double l; // length
        private double h; // height
        private double w; // width

        // Constructor
        public RectangularShape(double l, double w, double h)
        {
            this.l = l;
            this.w = w;
            this.h = h;
        }

        // Properties
        public virtual double L { get { return this.l; } }
        public virtual double H { get { return this.h; } }
        public virtual double W { get { return this.w; } }

        // Methods
        public virtual double Area()
        {
            double area = l * w;
            return area;
        }
        public virtual double Perimeter()
        {
            double perimeter = 2 * (l + w);
            return perimeter;
        }
        public abstract double Volume();
    }
}
