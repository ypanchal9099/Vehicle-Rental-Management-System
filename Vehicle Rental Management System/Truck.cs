//Truck.cs
using System;

namespace VehicleRental
{
    public class Truck : Vehicle
    {
        // Additional properties
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity} \nTruck Type: {TruckType} \nFour Wheel Drive: {FourWheelDrive}");
        }
    }
}

