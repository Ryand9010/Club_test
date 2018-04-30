using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Tree : IAge
    {
        private string _name;
        private DateTime _datePlanted;

       public Tree(string name, DateTime DatePlanted)
        {
            _name = name;
            _datePlanted = DatePlanted;
        }

        public string Name { get { return _name; } }
        public DateTime DatePlanted { get { return _datePlanted; } }

        public int GetAge()
        {

            int yearDiff = DateTime.Now.Year - _datePlanted.Year;
            if (_datePlanted.Month > DateTime.Now.Month)
            {
                yearDiff--;
            }
            return yearDiff;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
