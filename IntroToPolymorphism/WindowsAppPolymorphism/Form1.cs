using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolymorphicCircularShapeLib;

namespace WindowsAppPolymorphism
{
    public partial class Form1 : Form
    {
        List<CircularShape> circularShapesList = new List<CircularShape>();

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
            circularShapesList.Add(circle);
            // display
            Display(circle);
            MessageBox.Show(circle.ToString());
        }

        private void btnCreateCylinder_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();
            // create a Cylinder
            Cylinder cylinder = new Cylinder(radius, height);
            // Save
            circularShapesList.Add(cylinder);
            // display
            Display(cylinder);
            MessageBox.Show(cylinder.ToString());
        }

        private void btnCreateSphere_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            // Create a Sphere object
            Sphere sphere = new Sphere(radius);
            // Save
            circularShapesList.Add(sphere);
            // display it
            Display(sphere);
            MessageBox.Show(sphere.ToString());
        }

        private void btnCreateCone_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();
            // create a cone object
            Cone cone = new Cone(radius, height);
            // Save
            circularShapesList.Add(cone);
            // Display
            Display(cone);
            MessageBox.Show(cone.ToString());
        }

        //----------------------------------------------------------
        private void Display(CircularShape cs)
        {
            string[] items = {cs.GetType().Name,
                              cs.R.ToString("f3"),
                              cs.H.ToString("f3"),
                              cs.Perimeter().ToString("f3"),
                              cs.Area().ToString("f3"),
                              cs.Volume().ToString("f3")};
            ListViewItem lvi = new ListViewItem(items);
            // add the row to the listview
            listView1.Items.Add(lvi);
            // making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }
    }
}

// as an exercise
// repeat the Car Labs using Polymorphism principles
// have two displays: listview as normal
// and a richtextbox to display the return of ToString()