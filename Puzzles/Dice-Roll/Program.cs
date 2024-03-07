using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rolling a 6-sided die...");
        int result = DiceRoll();
        Console.WriteLine("The result is: " + result);
    }

    static int DiceRoll()
    {
        Random random = new Random();
        int result = random.Next(1, 7);
        return result;
    }
}
