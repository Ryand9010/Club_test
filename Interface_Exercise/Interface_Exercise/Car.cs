using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise
{
    public class Car : ILocation
    {
        private string _name;
        private string _plantName;
        private string _location;

        public Car(string name, string plantName, string location)
        {
            _name = name;
            _plantName = plantName;
            _location = location;
        }

        public string GetLocation()
        {
            string plantLocation = _plantName + ", " +  _location;
            return plantLocation;
        }
    }
}
