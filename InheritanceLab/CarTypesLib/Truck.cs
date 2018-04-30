using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTypesLib
{
    public class Truck : Car
    {
        // Private Field
        private string _maxTowing;

        // Constructor
        public Truck(string make, string model, int mileage, int year, decimal price,
                   string engineSize, int averageMpg, string maxTowing, int customerID)
                   : base(make, model, mileage,
                        year, price, engineSize,
                        averageMpg, customerID)
        {
            _maxTowing = maxTowing;
        }

        // Properties
        public string MaxTowing
        { get { return _maxTowing; } }
    }
}
