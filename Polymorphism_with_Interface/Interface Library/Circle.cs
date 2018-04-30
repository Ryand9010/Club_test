using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Library
{
    /*
     a class can direclty inherit from only one class
     (can have only one parent class, but it can have multiple
     parent interfaces => it can inherit from multiple interfaces)

        we say: a class inherits from another class
        prefer to say: a class implements an interface 
                       instead of a class inhereits an interface
        When a class implemets an interface, it must define all
        the methodsin the interface, it is  by default overriding 
        the methods. the keyword override is not allowed.
     * */
    public class Circle : IShape
    {
        // fields
        private double r; // radius

        // Constructor
        public Circle(double radius)
        {
            r = radius;
        }

        // Properties
        public double R { get { return r; } }

        // Methods
        public double Area()
        {
            return Math.PI * r * r;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public double Volume()
        {
            return 0;
        }
    }
}
// TO DO:
// Add a second class Rectangle that implemets IShape
// in Form1: define a List to hold both circles and rectangles
// add buttons to create random circles and rectangles, add them
// to the list and display them.
// Research  interfaces
