using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Flipping a coin...");
        string result = CoinFlip();
        Console.WriteLine("The result is: " + result);
    }

    static string CoinFlip()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 2);
        if (randomNumber == 0)
        {
            return "heads";
        }
        else
        {
            return "tails";
        }
    }
}
