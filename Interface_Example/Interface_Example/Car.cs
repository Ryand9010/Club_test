using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Car : IAge
    {
        private string _name;
        private DateTime _dateMade;


        public Car(string name, DateTime DateMade)
        {
            _name = name;
            _dateMade = DateMade;
        }

       
        public int GetAge()
        {

            int yearDiff = DateTime.Now.Year - _dateMade.Year;
            if (_dateMade.Month > DateTime.Now.Month)
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
