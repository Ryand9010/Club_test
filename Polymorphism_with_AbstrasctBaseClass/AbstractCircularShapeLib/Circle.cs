using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCircularShapeLib
{
    public class Circle : CircularShape
    {
        // constructor
        public Circle(double r) : base(r, 0)
        {

        }

        // Since the Volume was declared abstracgt
        // in the parent class, a child class
        // MUST override it
        public override double Volume()
        {
            return 0;
        }
    }
}
