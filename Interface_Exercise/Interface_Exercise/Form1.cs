using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Exercise
{
    public partial class Form1 : Form
    {
        List<ILocation> things = new List<ILocation>();
        public Form1()
        {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            Person p1 = new Person("Ryan", "16003 SE 251st ST");
            things.Add(p1);
            Person p2 = new Person("Bob", "154332 SE 12th ST");
            things.Add(p2);
            Tree t1 = new Tree("Maple", "North Carolina");
            things.Add(t1);
            Tree t2 = new Tree("Oak", "Texas");
            Car c1 = new Car("Kia", "Kia Manufacturing", "Seoul, South Korea");
            things.Add(c1);
            Car c2 = new Car("Ford", "Ford Manufacturing", "Georgia");
            things.Add(c2);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (ILocation obj in things)
            {
                richTextBox1.AppendText(obj.GetLocation() + "\n");
            }
        }
    }
}
