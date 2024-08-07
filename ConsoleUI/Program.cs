using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    // Abstract Vehicle class
    public abstract class Vehicle
    {
        // Properties with default values
        public string Year { get; set; } = "Unknown Year";
        public string Make { get; set; } = "Unknown Make";
        public string Model { get; set; } = "Unknown Model";

        // Abstract method with no implementation
        public abstract void DriveAbstract();

        // Virtual method with base implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in drive mode.");
        }
    }

    // Car class inheriting from Vehicle
    public class Car : Vehicle
    {
        // Unique property for Car
        public bool HasTrunk { get; set; }

        // Implementing the abstract method
        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Make} {Model} car is driving.");
        }
    }

    // Motorcycle class inheriting from Vehicle
    public class Motorcycle : Vehicle
    {
        // Unique property for Motorcycle
        public bool HasSideCart { get; set; }

        // Implementing the abstract method
        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Make} {Model} motorcycle is driving.");
        }

        // Overriding the virtual method
        public override void DriveVirtual()
        {
            Console.WriteLine($"The {Make} {Model} motorcycle is cruising along.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            // Create 1 Car instance
            Car car1 = new Car
            {
                Year = "2022",
                Make = "Toyota",
                Model = "Corolla",
                HasTrunk = true
            };

            // Create 1 Motorcycle instance
            Motorcycle motorcycle1 = new Motorcycle
            {
                Year = "2023",
                Make = "Harley-Davidson",
                Model = "Sportster",
                HasSideCart = false
            };

            // Create 2 instances of type Vehicle using derived class constructors
            Vehicle vehicle1 = new Car
            {
                Year = "2019",
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true
            };

            Vehicle vehicle2 = new Motorcycle
            {
                Year = "2020",
                Make = "Ducati",
                Model = "Monster",
                HasSideCart = true
            };

            // Add the 4 vehicles to the list
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            // Using a foreach loop to display each of the properties
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                vehicle.DriveAbstract(); // Call abstract method
                vehicle.DriveVirtual();  // Call virtual method
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("Calling Drive methods explicitly:");
            car1.DriveAbstract();
            car1.DriveVirtual();

            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            Console.ReadLine();
        }
    }
}
