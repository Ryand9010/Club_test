using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocationInterfaceLib;

namespace Interface_Example
{
    public partial class Form1 : Form
    {
        List<IAge> things = new List<IAge>();
        List<ILocation> locationList = new List<ILocation>();
        public Form1()
        {
            InitializeComponent();
            PopulateList();
            PopulateLocationList();
        }

        private void PopulateList()
        {
            Person p1 = new Person("David", new DateTime(1973, 2, 3));
            things.Add(p1);
            Tree tree1 = new Tree("Maple", new DateTime(1990, 4, 20));
            things.Add(tree1);
            Car car1 = new Car("Mazda", new DateTime(2010, 02, 11));
            things.Add(car1);         
        }
        private void PopulateLocationList()
        {
            LocationInterfaceLib.Person p = 
                new LocationInterfaceLib.Person("Tom",
                new Address("3000 NE 4th Street", "Renton", "WA", "98056"));
            locationList.Add(p);

            LocationInterfaceLib.Tree t = 
                new LocationInterfaceLib.Tree("Oak",
                new Address("6000 Grady Way", "Renton", "WA", "98052"));
            locationList.Add(t);

            LocationInterfaceLib.Car c = 
                new LocationInterfaceLib.Car("Toyota Camry",
                new Address("Main", "Detroit", "MI", "47022"));
            locationList.Add(c);
        }
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            foreach(IAge obj in things)
            {
                richTextBox1.AppendText(obj.ToString() + "\t" +
                                        obj.GetAge() + " years old" +
                                        "\n");
            }
        }
    }
}

// Add a button and display the locationList
