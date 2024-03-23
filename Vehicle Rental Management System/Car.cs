//Car.cs
using System;

namespace VehicleRental
{
    public class Car : Vehicle
    {
        // Additional properties
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats} \nEngine Type: {EngineType} \nTransmission: {Transmission} \nConvertible: {Convertible}");
        }
    }
}

