//Vehicle.cs
using System;

namespace VehicleRental
{
    public class Vehicle
    {
        // Properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        // Methods
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model} \nManufacturer: {Manufacturer} \nYear: {Year} \nRental Price: {RentalPrice:C}");
        }
    }
}

