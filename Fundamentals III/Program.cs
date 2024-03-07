using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
        PrintList(TestStringList);

        List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
        SumOfNumbers(TestIntList);

        List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
        Console.WriteLine("Maximum value: " + FindMax(TestIntList2));

        List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> squaredList = SquareValues(TestIntList3);
        Console.WriteLine("Squared values: ");
        foreach (int num in squaredList)
        {
            Console.WriteLine(num);
        }

        int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
        int[] nonNegatives = NonNegatives(TestIntArray);
        Console.WriteLine("Non-negative array: ");
        foreach (int num in nonNegatives)
        {
            Console.WriteLine(num);
        }

        Dictionary<string, string> TestDict = new Dictionary<string, string>();
        TestDict.Add("HeroName", "Iron Man");
        TestDict.Add("RealName", "Tony Stark");
        TestDict.Add("Powers", "Money and intelligence");
        PrintDictionary(TestDict);

        Console.WriteLine("Key 'RealName' exists: " + FindKey(TestDict, "RealName"));
        Console.WriteLine("Key 'Name' exists: " + FindKey(TestDict, "Name"));

        List<string> Names = new List<string>() { "Julie", "Harold", "James", "Monica" };
        List<int> Numbers = new List<int>() { 6, 12, 7, 10 };
        Dictionary<string, int> generatedDictionary = GenerateDictionary(Names, Numbers);
        Console.WriteLine("Generated Dictionary: ");
        foreach (var item in generatedDictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static void PrintList(List<string> MyList)
    {
        foreach (string item in MyList)
        {
            Console.WriteLine(item);
        }
    }

    static void SumOfNumbers(List<int> IntList)
    {
        int sum = 0;
        foreach (int num in IntList)
        {
            sum += num;
        }
        Console.WriteLine("Sum of numbers: " + sum);
    }

    static int FindMax(List<int> IntList)
    {
        int max = IntList[0];
        foreach (int num in IntList)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static List<int> SquareValues(List<int> IntList)
    {
        List<int> squaredList = new List<int>();
        foreach (int num in IntList)
        {
            squaredList.Add(num * num);
        }
        return squaredList;
    }

    static int[] NonNegatives(int[] IntArray)
    {
        for (int i = 0; i < IntArray.Length; i++)
        {
            if (IntArray[i] < 0)
            {
                IntArray[i] = 0;
            }
        }
        return IntArray;
    }

    static void PrintDictionary(Dictionary<string, string> MyDictionary)
    {
        foreach (var item in MyDictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
    {
        return MyDictionary.ContainsKey(SearchTerm);
    }

    static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
    {
        Dictionary<string, int> generatedDict = new Dictionary<string, int>();
        for (int i = 0; i < Names.Count; i++)
        {
            generatedDict.Add(Names[i], Numbers[i]);
        }
        return generatedDict;
    }
}

