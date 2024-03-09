using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    public string Name { get; set; }
    public int Wheels { get; set; }
    public bool HasEngine { get; set; }

    public Vehicle(string name, int wheels, bool hasEngine)
    {
        Name = name;
        Wheels = wheels;
        HasEngine = hasEngine;
    }

    public abstract void Move();
}

public class Car : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; }

    public Car(string name, string fuelType) : base(name, 4, true)
    {
        FuelType = fuelType;
        FuelTotal = 10; // Default fuel total
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"Added {Amount} units of {FuelType} fuel to the car. Total fuel now: {FuelTotal} units.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is moving on {Wheels} wheels.");
    }
}

public class Horse : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; }

    public Horse(string name, string fuelType) : base(name, 4, false)
    {
        FuelType = fuelType;
        FuelTotal = 10; // Default fuel total
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"Added {Amount} units of {FuelType} to the horse. Total fuel now: {FuelTotal} units.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is galloping.");
    }
}

public class Bicycle : Vehicle
{
    public Bicycle(string name) : base(name, 2, false)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is pedaling.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Gasoline");
        Horse horse = new Horse("Black Beauty", "Hay");
        Bicycle bicycle = new Bicycle("BMX");

        List<Vehicle> vehicles = new List<Vehicle> { car, horse, bicycle };

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();

            if (vehicle is INeedFuel)
            {
                INeedFuel fuelVehicle = (INeedFuel)vehicle;
                fuelVehicle.GiveFuel(10);
                Console.WriteLine($"{vehicle.Name} has {fuelVehicle.FuelTotal} units of {fuelVehicle.FuelType} fuel.");
            }
        }
    }
}
