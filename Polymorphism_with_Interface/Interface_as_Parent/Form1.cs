using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_Library;

namespace Interface_as_Parent
{
    public partial class Form1 : Form
    {

        List<IShape> shapesList = new List<IShape>();
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
            shapesList.Add(circle);
            // display
            Display(circle);
        }

        private void btnCreateRectangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double length = rand.Next(2, 20) + rand.NextDouble();
            double width = rand.Next(2, 20) + rand.NextDouble();
            // create a Rectangle
            Rectangle rectangle = new Rectangle(length, width);
            // Save
            shapesList.Add(rectangle);
            // display
            Display(rectangle);
        }

        private void Display(IShape cr)
        {
            string[] items = {cr.GetType().Name,
                              cr.R.ToString("f3"),
                              cr.L.ToString("f3"),
                              cr.W.ToString("f3"),
                              cr.Perimeter().ToString("f3"),
                              cr.Area().ToString("f3"),
                              cr.Volume().ToString("f3")};
            ListViewItem lvi = new ListViewItem(items);
            // add the row to the listview
            listView1.Items.Add(lvi);
            // making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }
    }
}
