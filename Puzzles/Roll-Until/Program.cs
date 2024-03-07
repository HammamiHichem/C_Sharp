using System;

class Program
{
    static void Main(string[] args)
    {
        int numberToRollFor = 3;
        string result = RollUntil(numberToRollFor);
        Console.WriteLine(result);
    }

    static string RollUntil(int numberToRollFor)
    {
        Random random = new Random();
        int rollsCount = 0;
        int result;
        do
        {
            result = random.Next(1, 7);
            rollsCount++;
        } while (result != numberToRollFor);

        return $"Rolled a {numberToRollFor} after {rollsCount} tries";
    }
}
