using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> results = StatRoll();
        Console.WriteLine("Results of 4 dice rolls: ");
        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
        Console.WriteLine("Largest value rolled: " + LargestValue(results));
    }

    static List<int> StatRoll()
    {
        List<int> results = new List<int>();
        Random random = new Random();
        for (int i = 0; i < 4; i++)
        {
            int result = random.Next(1, 7);
            results.Add(result);
        }
        return results;
    }

    static int LargestValue(List<int> results)
    {
        int max = results[0];
        foreach (int result in results)
        {
            if (result > max)
            {
                max = result;
            }
        }
        return max;
    }
}
