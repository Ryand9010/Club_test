using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Library
{
    /*
     an interface is like a pure abstract class
     (that is all the methods and properties are abstract)
     Furthermore, an interface does not contain any private field
     and No Constructor

        By default any method or property defined in an interface
        is considered public and abstract, therefore you don't 
        add the keyword public abstract to any method or property
        defined in an interface

        Cannot create an object of an interface

        Any child of an interface MUST override ALL the methods
        and properties

        an interface can be seen as a contract
     * */
    public interface IShape
    {
        double Volume();
        double Area();
        double Perimeter();

    }
}
