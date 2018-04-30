using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTypesLib
{
    public class Car
    {
        // Private Fields
        private string _make;
        private string _model;
        private int _mileage;
        private int _year;
        private decimal _price;
        private string _engineSize;
        private int _averageMpg;
        private int _customerID;

        // Constructor
        public Car(string make, string model, int mileage, int year, decimal price,
                    string engineSize, int averageMpg, int customerID)
        {
            _make = make;
            _model = model;
            _mileage = mileage;
            _year = year;
            _price = price;
            _engineSize = engineSize;
            _averageMpg = averageMpg;
            _customerID = customerID;
        }

        // Properties
        public string Make
        { get { return _make; } }

        public string Model
        { get { return _model; } }

        public int Mileage
        { get { return _mileage; } }

        public int Year
        { get { return _year; } }

        public decimal Price
        { get { return _price; } }

        public string EngineSize
        { get { return _engineSize; } }

        public int AverageMpg
        { get { return _averageMpg; } }

        public int CustomerID
        { get { return _customerID; } }

        // Methods
        private decimal LowerPriceBy(decimal percent)
        {
            _price -= percent * _price / 100;
            return _price;
        }

        public decimal ChangePrice(decimal price)
        {
            _price = price;
            return _price;
        }
    }
}
