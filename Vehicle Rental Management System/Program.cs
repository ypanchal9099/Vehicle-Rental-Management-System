using System;
using VehicleRental;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car = new Car
        {
            Model = "Toyota Camry",
            Manufacturer = "Toyota",
            Year = 2022,
            RentalPrice = 50,
            Seats = 5,
            EngineType = "V6",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "Ford F-150",
            Manufacturer = "Ford",
            Year = 2021,
            RentalPrice = 80,
            Capacity = 5,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Honda CB500F",
            Manufacturer = "Honda",
            Year = 2020,
            RentalPrice = 30,
            EngineCapacity = 500,
            FuelType = "Gasoline",
            HasFairing = true
        };

        // Creating rental agency and adding vehicles to fleet
        RentalAgency agency = new RentalAgency(3);
        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(motorcycle, 2);

        // Displaying details of each vehicle
        Console.WriteLine("Car Details:");
        Console.WriteLine("--------------");
        car.DisplayDetails();

        Console.WriteLine("\nTruck Details:");
        Console.WriteLine("-----------------");
        truck.DisplayDetails();

        Console.WriteLine("\nMotorcycle Details:");
        Console.WriteLine("----------------------");
        motorcycle.DisplayDetails();

        // Renting a vehicle
        agency.RentVehicle(0, 5); // Renting the car for 5 days
        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }
}

