using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractCircularShapeLib;

namespace Polymorphism_with_AbstrasctBaseClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CircularShape cs = new CircularShape(5,3);
            //the statement causes a compiler error

            //Cannot create an instance of an abstract
            //class
        }
    }
}
