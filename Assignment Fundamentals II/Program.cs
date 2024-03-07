using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Three Basic Arrays
        int[] numbersArray = new int[10]; // Create an integer array with values 0 through 9
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = i;
        }

        string[] namesArray = { "Tim", "Martin", "Nikki", "Sara" }; // Create a string array with names
        bool[] booleanArray = new bool[10]; // Create a boolean array of length 10
        for (int i = 0; i < booleanArray.Length; i++)
        {
            booleanArray[i] = i % 2 == 0; // Fill it with alternating true/false values
        }

        // List of Flavors
        List<string> flavorsList = new List<string>(); // Create a string List of ice cream flavors
        flavorsList.Add("Vanilla");
        flavorsList.Add("Chocolate");
        flavorsList.Add("Strawberry");
        flavorsList.Add("Mint");
        flavorsList.Add("Cookie Dough");

        Console.WriteLine($"Length of flavors list: {flavorsList.Count}"); // Output the length of the List
        Console.WriteLine($"Third flavor in the list: {flavorsList[2]}"); // Output the third flavor in the List
        flavorsList.RemoveAt(2); // Remove the third flavor using its index location
        Console.WriteLine($"New length of flavors list: {flavorsList.Count}"); // Output the length of the List again

        // User Dictionary
        Random random = new Random();
        Dictionary<string, string> userFlavorsDict = new Dictionary<string, string>(); // Create a dictionary for user flavors
        foreach (string name in namesArray)
        {
            int randomIndex = random.Next(flavorsList.Count); // Get a random index
            userFlavorsDict[name] = flavorsList[randomIndex]; // Add a random flavor to the user
        }

        Console.WriteLine("\nUser Dictionary:");
        foreach (var pair in userFlavorsDict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
            
        }
    }
}
