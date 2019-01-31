using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam_2018_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<VehicleManufacturer> listVeh = new List<VehicleManufacturer>();

            //creating vehicle manufacturer objects
            #region exam commented
            //VehicleManufacturer veh3 = new VehicleManufacturer()
            //{
            //    Name = "Volvo",
            //    Country = "Sweden"
            //};
            //VehicleManufacturer veh1 = new VehicleManufacturer()
            //{
            //    Name = "Mercedes",
            //    Country = "Germany"
            //};
            //VehicleManufacturer veh2 = new VehicleManufacturer()
            //{
            //    Name = "Renault",
            //    Country = "France"
            //};


            //listVeh.Add(veh1);
            //listVeh.Add(veh2);
            //listVeh.Add(veh3);
            #endregion

            //sorting
            listVeh.Sort();
            lbxManufacturer.ItemsSource = listVeh;
        }

        private DateTime RandomDate(Random randomFactory)
        {
            DateTime startDate = new DateTime(2016, 01, 01);
            DateTime endDate = new DateTime(2017, 01, 01);

            //calc the span 
            TimeSpan spanTime = endDate - startDate;

            //minutes
            int minutesMax = (int)spanTime.TotalMinutes;
            int addMinutes = randomFactory.Next(0, minutesMax);

            //add minutes to date
            TimeSpan newSpan = new TimeSpan(0, addMinutes, 0);
            DateTime newDate = startDate + newSpan;

            return newDate;
        }
        //Creating data
        public List <VehicleManufacturer> GetData()
        {
            List<VehicleManufacturer> Manufacturer = new List<VehicleManufacturer>();
            //instance of random
            Random randomFactory = new Random();
            DateTime date = new DateTime(2018, 1, 1);

            //Adding objects
            Car c1 = new Car() { Name = "Volvo", Country = "Sweden" };
            Bus b1 = new Bus() { Name = "Mercedes", Country = "Germany" };
            Truck t1 = new Truck() { Name = "Renault", Country = "France" };

            //Model mc1 = new Model() { ModelName = "XC90", DateOfInitialSale = date };

            return Manufacturer;
        }
   
    }


}
