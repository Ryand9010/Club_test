using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationInterfaceLib
{
    public class Tree : ILocation
    {
        private string _name;
        private Address _treeLocation;

        public Tree(string name, Address address)
        {
            _name = name;
            _treeLocation = address;
        }

        public string GetLocation()
        {
            return _treeLocation.ToString();
        }
    }
}
