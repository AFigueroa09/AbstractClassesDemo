using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            Car porshe = new Car()
            {
                Model = "Cayman",
                Make = "Porshe",
                Year = "2005",
                HasTrunk = true
            };

            Motorcycle ducati = new Motorcycle()
            {
                Model = "SomeModel",
                Make = "Ducati",
                Year = "2009",
                HasSideCart = false
            };

            Vehicle toyota = new Car()
            {
                Model = "Corolla",
                Make = "Toyota",
                Year = "2016"
            };

            Motorcycle harley = new Motorcycle()
            {
                Model = "SomeModel",
                Make = "Harley Davidson",
                Year = "2010",
                HasSideCart = true
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(toyota);
            vehicles.Add(harley);
            vehicles.Add(porshe);
            vehicles.Add(ducati);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Model}, {vehicle.Make}, {vehicle.Year}");
            }
            // Call each of the drive methods for one car and one motorcycle
            toyota.DriveVirtual();
            toyota.DriveAbstract();

            ducati.DriveVirtual();
            ducati.DriveAbstract();

            #endregion
            Console.ReadLine();
        }
    }
}
