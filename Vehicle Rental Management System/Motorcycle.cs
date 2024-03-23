//Motorcycle.cs
using System;

namespace VehicleRental
{
    public class Motorcycle : Vehicle
    {
        // Additional properties
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            //Console.WriteLine("\nMotorcycle Details");
            //Console.WriteLine("\n---------------------");
            Console.WriteLine($"Engine Capacity: {EngineCapacity} \nFuel Type: {FuelType} \nHas Fairing: {HasFairing}");
        }
    }
}

