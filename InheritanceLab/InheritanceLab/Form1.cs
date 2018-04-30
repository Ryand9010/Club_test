using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarTypesLib;

/*
 * Ryan Davis
 * Partner: Lane Young
 * Inheritance Lab Assignment
 * */

namespace InheritanceLab
{
    public partial class Form1 : Form
    {
        // List to store car objects
        List<Car> carList = new List<Car>();
        // booleans to filter which "list" is displayed
        // when changing price
        bool allDisplay = false;
        bool makeDisplay = false;
        bool idDisplay = false;
        bool typeDisplay = false;
        bool expensiveDisplay = false;
        bool cheapDisplay = false;
        public Form1()
        {
            InitializeComponent();
            PopulateCarsList();
        }
      
        // Method for populating carList
        private void PopulateCarsList()
        {
            Car c = new Car("Toyota", "Camry", 89000, 2007, 8975.99M, "2.0L 4cyl", 28, 1);
            carList.Add(c);
            Truck t = new Truck("Ford", "F-150", 3000, 2016, 38500M, "5.2L V8", 18, "12000 lbs", 2);
            carList.Add(t);
            c = new Car("Volkswagen", "Golf", 110000, 2005, 3500M, "1.8L 4cyl Turbo", 25, 3);
            carList.Add(c);
            SportsCar s = new SportsCar("Mazda", "Miata", 13000, 2001, 6000, "2.2L 4cyl", 27, 6.2, 4);
            carList.Add(s);
            s = new SportsCar("Subaru", "BRZ", 2000, 2018, 25000, "2.L 4cyl Turbo", 33, 6.0, 5);
            carList.Add(s);
            t = new Truck("Chevrolet", "Silverado", 15, 2011, 11000, "4.3L V6", 18, "12400 lbs", 6);
            carList.Add(t);
            c= new Car("Ford", "Fiesta", 28, 2017, 14000, "2.0L 4cyl", 27, 7);
            carList.Add(c);
            s = new SportsCar("Audi", "R8", 8000, 2016, 90000, "5.2 V10", 15, 3.8, 8);
            carList.Add(s);
            t = new Truck("Dodge", "RAM 1500", 120000, 2008, 12908M, "5.7L V8", 19, "12200 lbs", 9);
            carList.Add(t);
            c = new Car("Dodge", "Neon", 50000, 2009, 5545, "2.4L 4cyl", 22, 1);
            carList.Add(c);
            s = new SportsCar("Ferrari", "LaFerrari", 900, 2003, 4000000, "6.3L V12", 8, 2.4, 8);
            carList.Add(s);
            s = new SportsCar("Honda", "s2000", 135321, 2001, 11300, "2.0l 4cyl", 29, 6.1, 10);
            carList.Add(s);
            t = new Truck("Nissan", "Frontier", 44390, 2014, 26500, "5.0L V6", 16, "10400 lbs", 11);
            carList.Add(t);
            c = new Car("Volkswagen", "Jetta", 120331, 2004, 3700, "1.8L 4cyl Turbo", 24, 12);
            carList.Add(c);
            t = new Truck("Toyota", "Tacoma", 12986, 2016, 21000, "3.5L V6", 17, "13300 lbs", 13);
            carList.Add(t);
            c = new Car("Subaru", "WRX", 78102, 2007, 14500, "2.5L 4cyl Turbo", 24, 14);
            carList.Add(c);
            c = new Car("Chrysler", "300", 89334, 2009, 8750, "3.2L V6", 19, 15);
            carList.Add(c);
            s = new SportsCar("Lamborghini", "Aventador", 900, 2017, 750000, "6.2L V12", 9, 3.1, 3);
            carList.Add(s);
            t = new Truck("GMC", "Sierra 1500", 3004, 2018, 29000, "4.6L V8", 16, "12900 lbs", 16);
            carList.Add(t);
            t = new Truck("Cadillac", "Escalade", 14500, 2017, 57000, "5.7L V8", 16, "11000 lbs", 3);
            carList.Add(t);
            s = new SportsCar("BMW", "M3", 10670, 2017, 66500, "3.5L I6 Twin Turbo", 20, 4.5, 17);
            carList.Add(s);
            c = new Car("Ford", "Pinto", 200212, 1974, 2000, "2.3L I4", 30, 18);
            carList.Add(c);
            s = new SportsCar("Ford", "GT", 5000, 2018, 1200000, "3.5L V6 Twin Turbo", 17, 4.7, 17);
            carList.Add(s);
            t = new Truck("Chevrolet", "Colorado", 300, 2019, 34000, "5.8L V8", 17, "14300 lbs", 19);
            carList.Add(t);
            s = new SportsCar("Bugatti", "Veryron", 300, 2018, 1000000, "7L V12", 6, 2.4, 17);
            carList.Add(s);
            t = new Truck("Subaru", "Baja", 54987, 2006, 13280, "2.4L 4cyl", 20, "7500 lbs", 3);
            carList.Add(t);
            t = new Truck("Honda", "RidgeLine", 80200, 2010, 19400, "3.2L V6", 22, "8000 lbs", 20);
            carList.Add(t);
            c = new Car("Nissan", "Altima", 67000, 2010, 8000, "2.5L 4cyl", 28, 18);
            carList.Add(c);
            s = new SportsCar("Ferrari", "F-430", 400, 2009, 677988, "6L V12", 9, 3.6, 2);
            carList.Add(s);
            s = new SportsCar("Porsche", "911", 9443, 2014, 80650, "3.8L I6", 22, 4.8, 3);
            carList.Add(s);
            c = new Car("Tesla", "Model S", 45, 2019, 105000, "Electric", 105, 15);
            carList.Add(c);
        }

        // Method to display all cars
        private void DisplayCars(List<Car> cars)
        {
            

            listView1.Items.Clear();
            foreach(Car c in cars)
            {
                if (c is Truck)
                {
                    // Cast c to a Truck Object
                    Truck t = (Truck)c;
                    // create a listviewItem
                    string[] items = {t.Make.ToString(),
                                      t.Model.ToString(),
                                      t.Mileage.ToString("N0"),
                                      t.Year.ToString(),
                                      t.Price.ToString("C"),
                                      t.EngineSize.ToString(),
                                      t.AverageMpg.ToString(),
                                      " - ",
                                      t.MaxTowing.ToString(),
                                      t.CustomerID.ToString()};
                    ListViewItem lvi = new ListViewItem(items);
                    listView1.Items.Add(lvi);
                }
                else if(c is SportsCar)
                {
                    // Cast c to a SportsCar Object
                    SportsCar s = (SportsCar)c;
                    // create a listviewItem
                    string[] items = {s.Make.ToString(),
                                      s.Model.ToString(),
                                      s.Mileage.ToString("N0"),
                                      s.Year.ToString(),
                                      s.Price.ToString("C"),
                                      s.EngineSize.ToString(),
                                      s.AverageMpg.ToString(),
                                      s.ZeroToSixty.ToString(),
                                      " - ",
                                      s.CustomerID.ToString()};
                    ListViewItem lvi = new ListViewItem(items);
                    listView1.Items.Add(lvi);
                }
                else
                {
                    // create a listviewItem
                    string[] items = {c.Make.ToString(),
                                      c.Model.ToString(),
                                      c.Mileage.ToString("N0"),
                                      c.Year.ToString(),
                                      c.Price.ToString("C"),
                                      c.EngineSize.ToString(),
                                      c.AverageMpg.ToString(),
                                      " - ",
                                      " - ",
                                      c.CustomerID.ToString()};
                    ListViewItem lvi = new ListViewItem(items);
                    listView1.Items.Add(lvi);

                   
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setting the comboboxes to the first selection
            // be default
            cboCarType.SelectedIndex = 0;
            cboMake.SelectedIndex = 0;
            cboCustomerID.SelectedIndex = 0;
            lblTotalPrice.Visible = false;
        }

        // Button to display call cars by calling the display method
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //setting the corrisponding 
            // boolean to true
            DisplayCars(carList);
            allDisplay = true;
            makeDisplay = false;
            idDisplay = false;
            typeDisplay = false;
        }


        // Method to Get the Most Expensive Car from the list
        private List<Car> GetMostExpensiveCar(List<Car> cars)
        {
            // making a list for the most expensive car, which
            // will only hold one car
            List<Car> expensiveCarList = new List<Car>();
            decimal mostExpensive = 0;
            int mostExpensiveIndex = 0;

            for (int i  = 0; i < cars.Count; i++)
            {
                if (cars[i].Price > mostExpensive)
                {
                    mostExpensive = cars[i].Price;
                    mostExpensiveIndex = i;
                }
            }

            expensiveCarList.Add(cars[mostExpensiveIndex]);
            return expensiveCarList;
        }


        // Button Display most expensive car, calling the display method
        private void btnDisplayMostExpensiveCar_Click(object sender, EventArgs e)
        {
            // creating a new list and setting to the result of GetMostExpensiveCar method
            List<Car> cars = GetMostExpensiveCar(carList);
            // using the original display method to call the above list for the most expensive\

            // using display method and pass to it
            // above list "cars"
            DisplayCars(cars);

            //setting the corrisponding 
            // boolean to true
            allDisplay = false;
            makeDisplay = false;
            idDisplay = false;
            typeDisplay = false;
            cheapDisplay = false;
            expensiveDisplay = true;
        }


        // Method to Get the Cheapest Car from the list
        private List<Car> GetCheapestCar(List<Car> cars)
        {
            // making a list for the most expensive car, which
            // will only hold one car
            List<Car> cheapCarList = new List<Car>();
            decimal cheapest = 10000000;
            int cheapIndex = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Price < cheapest)
                {
                    cheapest = cars[i].Price;
                    cheapIndex = i;
                }
            }

            cheapCarList.Add(cars[cheapIndex]);
            return cheapCarList;
        }

        // Button to Display the Cheapest Car, calling the display method
        private void btnDisplayCheapestCar_Click(object sender, EventArgs e)
        {
            // creating a new list and setting to the result of GetCheapestCar method
            List<Car> cars = GetCheapestCar(carList);
            // using the original display method to call the above list for the cheapest
            DisplayCars(cars);

            //setting the corrisponding 
            // boolean to true
            allDisplay = false;
            makeDisplay = false;
            idDisplay = false;
            typeDisplay = false;
            cheapDisplay = true;
            expensiveDisplay = false;
        }
      
        // Method to Get Cars By Make
        private List<Car> GetCarsByMake(string make)
        {
            List<Car> carByMake = new List<Car>();
            foreach (Car c in carList)
            {
                if (c.Make == make)
                {
                    carByMake.Add(c);
                }               
            }
            return carByMake;
        }

        // Button to Display Cars by Make
        private void btnDisplayByMakes_Click(object sender, EventArgs e)
        {
            List<Car> carsByMake = GetCarsByMake(cboMake.Text);
            // calling display method and passing the carsByMake list
            DisplayCars(carsByMake);

            //setting the corrisponding 
            // boolean to true
            allDisplay = false;
            makeDisplay = true;
            idDisplay = false;
            typeDisplay = false;
            cheapDisplay = false;
            expensiveDisplay = false;
        }

        // Method to Get Cars By CustomerID
        private List<Car> GetCarsByCustomerID(int id)
        {


            List<Car> carByID = new List<Car>();
            foreach (Car c in carList)
            {
                if (c.CustomerID == id)
                {
                    carByID.Add(c);
                }
            }
            return carByID;
        }
        
        // Button to display cars by CustomerID, calling the display method
        private void btnDisplayByID_Click(object sender, EventArgs e)
        {          
            List<Car> carByID = GetCarsByCustomerID(int.Parse(cboCustomerID.Text));
            DisplayCars(carByID);

            //setting the corrisponding 
            // boolean to true
            allDisplay = false;
            makeDisplay = false;
            idDisplay = true;
            typeDisplay = false;
            cheapDisplay = false;
            expensiveDisplay = false;
        }

        // Method to Get cars By Type
        private List<Car> GetCarsByType(string carType)
        {
            List<Car> carByType = new List<Car>();
            foreach (Car c in carList)
            {
                if (carType == c.GetType().Name)
                {
                    carByType.Add(c);
                }
            }
            return carByType;
        }

        // Button to display cars by Type, calling the display method
        private void btnDisplayByType_Click(object sender, EventArgs e)
        {
            List<Car> carByType = GetCarsByType(cboCarType.Text);
            DisplayCars(carByType);

            //setting the corrisponding 
            // boolean to true
            allDisplay = false;
            makeDisplay = false;
            idDisplay = false;
            typeDisplay = true;
            cheapDisplay = false;
            expensiveDisplay = false;
        }

        // Method to display total prices of selected Cars
        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            decimal priceTotal = 0;
            List<Car> carPrices = GetCarsByType(cboCarType.Text);
            foreach (Car c in carPrices)
            {
                priceTotal += c.Price;
            }
            lblTotalPrice.Visible = true;
            lblTotalPrice.Text = priceTotal.ToString("C");
        }

        // Button to change price of a car to what the user has entered
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            // making sure something has been selected in the listview
            if (listView1.SelectedItems.Count > 0)
            {
                // getting listview selection
                int index = listView1.SelectedIndices[0];


                // if statement that checks for which
                // boolean is currently true, so when
                // the price changes, the right list is
                // still displayed
                if (allDisplay)
                {
                    carList[index].ChangePrice(decimal.Parse(txtChangePrice.Text));
                    DisplayCars(carList);
                }
                else if (expensiveDisplay)
                {
                    List<Car> expensiveCar = GetMostExpensiveCar(carList);
                    expensiveCar[index].ChangePrice(decimal.Parse(txtChangePrice.Text));
                    DisplayCars(expensiveCar);
                }
                else if (cheapDisplay)
                {
                    List<Car> cheapCar = GetCheapestCar(carList);
                    cheapCar[index].ChangePrice(decimal.Parse(txtChangePrice.Text));
                    DisplayCars(cheapCar);
                }
                else if (makeDisplay)
                {
                    List<Car> carsByMake = GetCarsByMake(cboMake.Text);
                    carsByMake[index].ChangePrice(decimal.Parse(txtChangePrice.Text));
                    DisplayCars(carsByMake);
                }
                else if (idDisplay)
                {
                    List<Car> carsByID = GetCarsByCustomerID(int.Parse(cboCustomerID.Text));
                    carsByID[index].ChangePrice(decimal.Parse(txtChangePrice.Text));
                    DisplayCars(carsByID);
                }
                else
                {
                    List<Car> carsByType = GetCarsByType(cboCarType.Text);
                    carsByType[index].ChangePrice(decimal.Parse(txtChangePrice.Text));
                    DisplayCars(carsByType);
                }
            }
        }
    }
}
