using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Person : IAge
    {
        private string _name;
        private DateTime _dateOfBirth;

        public Person(string name, DateTime dateOfBirth)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
        }
        
        public int GetAge()
        {
            
            int yearDiff = DateTime.Now.Year - _dateOfBirth.Year;
            if(_dateOfBirth.Month > DateTime.Now.Month)
            {
                yearDiff--;
            }
            return yearDiff;
        }
        public override string ToString()
        {
            return _name;
        }

        //Exercise
        // Define an interface ILocation with a method GetLocation
        // Define a class Person that implements the ILocation. Have
        // return the full address of the person
        // Define a class Tree that implements the ILocation. Have it
        // return the location where the tree is planted (Tacoma, WA)
        // Define a class Car that implements the ILocation. Have it
        // return the plant name and location

        // in Form1 create a list of 6 objects or more (2 of each)
        // Display all

    }
}
