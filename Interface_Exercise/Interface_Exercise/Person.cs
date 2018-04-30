using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise
{
    public class Person : ILocation
    {
        private string _name;
        private string _address;

        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public string GetLocation()
        {
            return _address;
        }
    }
}
