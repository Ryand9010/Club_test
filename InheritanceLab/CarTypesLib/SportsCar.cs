using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTypesLib
{
    public class SportsCar : Car
    {
        // Private Field
        private double _zeroToSixty;

        // Constructor
        public SportsCar(string make, string model, int mileage, int year, decimal price,
                   string engineSize, int averageMpg, double zeroToSixty, int customerID)
                   :base(make, model, mileage,
                        year, price, engineSize,
                        averageMpg, customerID)
        {
            _zeroToSixty = zeroToSixty;
        }

        // properties
        public double ZeroToSixty
        { get { return _zeroToSixty; } }
      
        
        
           
    }
}
