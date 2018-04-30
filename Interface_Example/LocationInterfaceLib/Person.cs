using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationInterfaceLib
{
    public class Person : ILocation
    {
        private string _name;
        private Address _personAddress;
        
        //Constructor
        public Person(string name, Address address)
        {
            _name = name;
            _personAddress = address;
        }

        public string Name { get { return _name; } }

        public string GetLocation()
        {
            return _personAddress.ToString();
        }
    }
}
