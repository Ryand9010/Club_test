using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Circle
    {
        //private field
        private double _radius;

        // constructor
        public Circle(double radius)
        {
            _radius = radius;
        }
        // properties
        public double Radius { get { return  _radius; } }
        
        // methods -- Complete code
        public double Area()
        {
            
            double area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }
        public double Perimeter()
        {
            double perimeter = 2 * Math.PI * _radius;
            return perimeter;
        }
        public double Volume()
        {
            return 0;
            
        }

    }
}
