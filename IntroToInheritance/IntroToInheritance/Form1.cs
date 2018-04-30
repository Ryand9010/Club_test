using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularShapesLib;

namespace IntroToInheritance
{
    public partial class Form1 : Form
    {
        /*
         Inheritance
        ============
        Deals with a class inheriting another class
        Another term for inheriting is extending (java uses
        the term extending)

            if a class A inherits (or extends) class B, 
            then name class B as the base class or the parent class
            and class A as the child class or the derived class

            Inheritance results in  a child parent relationship

            A Parent calss can have multiple child classes
            but
            A child can have only one Parent class

            a class has:
              -private fields
              -contructor
              -properties
              -methods

            a child class would inherit
              -private fields: but has no direct access to them
              -properties (has access to them because they are public)
              -methods (has access to the public methods)

            a child class DOES NOT inherit the parent constructor
         */

        List<Circle> circularShapes = new List<Circle>();
        // this list can store circle objects as well as any child of circle
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            // create a Circle
            Circle circle = new Circle(radius);
            // Save
            circularShapes.Add(circle);
            // display
            Display(circle);
        }
        private void btnCreateCylinder_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();

            // Create a cylinder object
            Cylinder cylinder = new Cylinder(radius, height);

            // display it
            // you could and should use the Display(Circle c) method
            // We are calling a display method that accepts Circle object
            // but we are passing it a Cylinder object
            // this is possible because a Cylinder object "is a" Circle
            // (of type Cirlce)

            // Save
            circularShapes.Add(cylinder);
            // Display
            Display(cylinder);

        }
        private void btnCreateSphere_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            // Create a Sphere object
            Sphere sphere = new Sphere(radius);
            // Save
            circularShapes.Add(sphere);
            // display it
            Display(sphere);
        }
        private void btnCreateCone_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();
            // create a cone object
            Cone cone = new Cone(radius, height);
            // Save
            circularShapes.Add(cone);
            // Display
            Display(cone);
        }


        // method to display a Circle object
        private void Display(Circle c)
        {
            ListViewItem lvi = null;

            if (c is Cone)
            {
                // cast C to a cone object
                Cone co = (Cone)c;
                // create a listviewItem (one row in a listview)
                string[] items = {co.GetType().Name,
                              co.Radius.ToString("f3"),
                              co.Height.ToString("f3"),
                              co.Perimeter().ToString("f3"),
                              co.Area().ToString("f3"),
                              co.Volume().ToString("f3")};
                lvi = new ListViewItem(items);
            }
            else if (c is Cylinder)
            {
                // cast C to a cylinder object
                Cylinder cy = (Cylinder)c;
                // create a listviewItem (one row in a listview)
                string[] items = {cy.GetType().Name,
                              cy.Radius.ToString("f3"),
                              cy.Height.ToString("f3"),
                              cy.Perimeter().ToString("f3"),
                              cy.Area().ToString("f3"),
                              cy.Volume().ToString("f3")};
                lvi = new ListViewItem(items);
            }
            else if (c is Sphere)
            {
                // castc to a Sphere object
                Sphere sp = (Sphere)c;
                // create a listviewItem
                string[] items = {sp.GetType().Name,
                              sp.Radius.ToString("f3"),
                              "0",
                              sp.Perimeter().ToString("f3"),
                              sp.Area().ToString("f3"),
                              sp.Volume().ToString("f3")};
                lvi = new ListViewItem(items);
            }           
            else
            {
                // create a listviewItem (one row in a listview)
                string[] items = {c.GetType().Name,
                              c.Radius.ToString("f3"),
                              "0",
                               c.Perimeter().ToString("f3"),
                               c.Area().ToString("f3"),
                               c.Volume().ToString("f3")};
                 lvi = new ListViewItem(items);
            }
            // add the row to the listview
            listView1.Items.Add(lvi);

            // making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            cboShapeNames.SelectedIndex = 0;
        }

        private void btnGetSelectedShape_Click(object sender, EventArgs e)
        {
            // get selected shapeName
            string shapeName = cboShapeNames.Text;
            // display by shape name
            DisplayByShape(shapeName);
        }
        // Method that displays a given shape from the 
        // circularshapes list
        private void  DisplayByShape(string shapeName)
        {
            listView1.Items.Clear();
            // sequence through the circularShapes list
            // capture or filter in only th eones with the 
            // given shapeName
            foreach(Circle c in circularShapes)
            {
                if(c.GetType().Name == shapeName)
                {
                    Display(c);
                }
            }
        }

        private void btnComputeAvgVolAllShapes_Click(object sender, EventArgs e)
        {
            // average volume of ALL the shapes
            double avgVolume = GetAverageVolOfShapes(circularShapes);
            // display in a message box
            MessageBox.Show($"Average Volume: {avgVolume.ToString("n3")}");
            // Define a method that returns the average volume of 
            // a list of shapes
        }
        private double GetAverageVolOfShapes(List<Circle> shapes)
        {
            double totalVolume = 0;

            foreach (Circle c in shapes)
            {
                if (c is Cone)
                {
                    // Cast c to a cone
                    Cone co = (Cone)c;
                    totalVolume += co.Volume();
                }
                else if (c is Cylinder)
                {
                    // cast C to a cylinder object
                    Cylinder cy = (Cylinder)c;
                    totalVolume += cy.Volume();
                }
                else if (c is Sphere)
                {
                    // castc to a Sphere object
                    Sphere sp = (Sphere)c;
                    totalVolume += sp.Volume();
                }
                else
                {
                    totalVolume += c.Volume();
                }
            }
            return totalVolume / shapes.Count;
        }
    }
}
// Exercise 1
// Add a listbox with the name of all the shapes you have
// add a button to display (in the listview) only the selected shape 
// from the circularShapes list
//
// Exercise 2
// Add Button  to compute the Average Volume
// Define a method that takes a list of shapes and returns
// the average volume. call the method from a button and display
// the resultin a messagebox 
//
// Exercise 3
// add button to compute the average volume of the selected shapenames
// define a method GetAvgVolumeBYShapeName