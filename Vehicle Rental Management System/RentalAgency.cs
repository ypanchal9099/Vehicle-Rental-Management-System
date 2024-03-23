//RentalAgency.cs
using System;

namespace VehicleRental
{
    public class RentalAgency
    {
        // Properties
        private Vehicle[] Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        // Constructor
        public RentalAgency(int fleetSize)
        {
            Fleet = new Vehicle[fleetSize];
            TotalRevenue = 0;
        }

        // Method to add vehicle to the fleet
        public void AddVehicle(Vehicle vehicle, int index)
        {
            if (index >= 0 && index < Fleet.Length)
            {
                Fleet[index] = vehicle;
            }
            else
            {
                Console.WriteLine("Invalid index for adding vehicle.");
            }
        }

        // Method to remove vehicle from the fleet
        public void RemoveVehicle(int index)
        {
            if (index >= 0 && index < Fleet.Length)
            {
                Fleet[index] = null;
            }
            else
            {
                Console.WriteLine("Invalid index for removing vehicle.");
            }
        }

        // Method to rent a vehicle
        public void RentVehicle(int index, int days)
        {
            if (index >= 0 && index < Fleet.Length && Fleet[index] != null)
            {
                double rentalCost = Fleet[index].RentalPrice * days;
                TotalRevenue += rentalCost;
                Console.WriteLine($"\nVehicle rented for {days} days. \nTotal cost: {rentalCost:C}");
            }
            else
            {
                Console.WriteLine("Invalid index for renting vehicle or vehicle not available.");
            }
        }
    }
}

