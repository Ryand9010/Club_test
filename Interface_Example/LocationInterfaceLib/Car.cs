using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationInterfaceLib
{
    public class Car : ILocation
    {
        private string _name;
        private Address _carFactory;

        public Car(string name, Address address)
        {
            _name = name;
            _carFactory = address;
        }

        public string GetLocation()
        {
            return _carFactory.ToString();
        }
    }
}
