using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise
{
    public class Tree : ILocation
    {
        private string _name;
        private string _location;

        public Tree(string name, string location)
        {
            _name = name;
            _location = location;
        }

        public string GetLocation()
        {
            return _location;
        }
    }
}
