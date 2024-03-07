using System;
using System.Collections.Generic;

public class Vehicle
{
    // Fields
    private string name;
    private int passengers;
    private string color;
    private bool hasEngine;
    private int distanceTraveled;

    // Constructors
    public Vehicle(string name, int passengers, string color, bool hasEngine)
    {
        this.name = name;
        this.passengers = passengers;
        this.color = color;
        this.hasEngine = hasEngine;
        this.distanceTraveled = 0;
    }

    public Vehicle(string name, string color)
    {
        this.name = name;
        this.color = color;
        this.passengers = 4; // Default value for passengers
        this.hasEngine = true; // Default value for hasEngine
        this.distanceTraveled = 0;
    }

    // Methods
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Has Engine: {(hasEngine ? "Yes" : "No")}");
        Console.WriteLine($"Distance Traveled: {distanceTraveled} miles\n");
    }

    public void Travel(int distance)
    {
        distanceTraveled += distance;
        Console.WriteLine($"The vehicle has traveled {distance} miles.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create vehicles using different constructors
        Vehicle car1 = new Vehicle("Honda Accord", 5, "Blue", true);
        Vehicle car2 = new Vehicle("Tesla Model S", 4, "Red", true);
        Vehicle bike1 = new Vehicle("Mountain Bike", "Black");
        Vehicle bike2 = new Vehicle("Road Bike", "White");

        // Put all vehicles into a List
        List<Vehicle> vehicles = new List<Vehicle> { car1, car2, bike1, bike2 };

        // Loop through the List and run ShowInfo() method for each vehicle
        foreach (var vehicle in vehicles)
        {
            vehicle.ShowInfo();
        }

        // Make one of the vehicles Travel 100 miles
        car1.Travel(100);

        // Print the information of the vehicle to verify the distance traveled went up
        car1.ShowInfo();

        // Bonus: Manually set the distance traveled field to 350 (not recommended)
        // car2.distanceTraveled = 350; // This line will not work if distanceTraveled is private

        // Explanation: It's not best practice to allow users to change distance traveled directly
        // without going through the Travel() method because we lose control over the validation 
        // and consistency checks that might be implemented in the Travel() method.

        // Bonus: Make the distance traveled field private
        // This will affect the code in Program.cs because now we cannot access distanceTraveled directly.
        // We have to use the Travel() method to update the distance traveled, ensuring proper validation and consistency.
    }
}

