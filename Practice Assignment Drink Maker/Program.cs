using System;
using System.Collections.Generic;

public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;
    
    public Drink(string name, string color, double temp, bool isCarb, int calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = isCarb;
        Calories = calories;
    }

    // Method to display information about the drink
    public virtual void ShowDrink()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}, Temperature: {Temperature}, Is Carbonated: {IsCarbonated}, Calories: {Calories}");
    }
}

public class Soda : Drink
{
    public bool IsDiet;

    public Soda(string name, string color, double temp, bool isCarb, int calories, bool isDiet) 
        : base(name, color, temp, isCarb, calories)
    {
        IsDiet = isDiet;
    }

    // Override method to display information about the soda
    public override void ShowDrink()
    {
        Console.WriteLine($"Soda - Name: {Name}, Color: {Color}, Temperature: {Temperature}, Is Carbonated: {IsCarbonated}, Calories: {Calories}, Is Diet: {IsDiet}");
    }
}

public class Coffee : Drink
{
    public string RoastValue;
    public string BeansType;

    public Coffee(string name, string color, double temp, bool isCarb, int calories, string roastValue, string beansType) 
        : base(name, color, temp, isCarb, calories)
    {
        RoastValue = roastValue;
        BeansType = beansType;
    }

    // Override method to display information about the coffee
    public override void ShowDrink()
    {
        Console.WriteLine($"Coffee - Name: {Name}, Color: {Color}, Temperature: {Temperature}, Is Carbonated: {IsCarbonated}, Calories: {Calories}, Roast Value: {RoastValue}, Beans Type: {BeansType}");
    }
}

public class Wine : Drink
{
    public string Region;
    public int BottledYear;

    public Wine(string name, string color, double temp, bool isCarb, int calories, string region, int bottledYear) 
        : base(name, color, temp, isCarb, calories)
    {
        Region = region;
        BottledYear = bottledYear;
    }

    // Override method to display information about the wine
    public override void ShowDrink()
    {
        Console.WriteLine($"Wine - Name: {Name}, Color: {Color}, Temperature: {Temperature}, Is Carbonated: {IsCarbonated}, Calories: {Calories}, Region: {Region}, Bottled Year: {BottledYear}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each drink
        Soda cola = new Soda("Cola", "Brown", 4.0, true, 150, true);
        Coffee latte = new Coffee("Latte", "Brown", 70.0, false, 100, "Medium", "Arabica");
        Wine merlot = new Wine("Merlot", "Red", 18.0, false, 125, "France", 2019);

        // Add all instances to a List of Drinks
        List<Drink> AllBeverages = new List<Drink>();
        AllBeverages.Add(cola);
        AllBeverages.Add(latte);
        AllBeverages.Add(merlot);

        // Display information about each drink
        foreach (Drink drink in AllBeverages)
        {
            drink.ShowDrink();
        }

        // Bonus: Coffee MyDrink = new Soda(); // This line will not work because Soda and Coffee are not related by inheritance.
        // You cannot assign a Soda object to a Coffee variable directly because they are of different types.
        // They do not share an inheritance relationship or interface implementation.
    }
}

