using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Print values from 1 to 255 using a while loop
        Console.WriteLine("Values from 1 to 255:");
        int i = 1;
        while (i <= 255)
        {
            Console.Write(i + " ");
            i++;
        }
        Console.WriteLine(); // Adding a newline for better readability

        // Task 2 & 3: Generate 5 random numbers between 10 and 20 using a while loop and print their sum
        int sumRandom = 0;
        Random rand = new Random();
        Console.WriteLine("5 random numbers between 10 and 20:");
        int count = 0;
        while (count < 5)
        {
            int randomNum = rand.Next(10, 21);
            Console.Write(randomNum + " ");
            sumRandom += randomNum;
            count++;
        }
        Console.WriteLine("\nSum of the 5 random numbers: " + sumRandom);

        // Task 4, 5 & 6: Print Fizz, Buzz, and FizzBuzz using a while loop
        Console.WriteLine("Fizz, Buzz, and FizzBuzz:");
        int j = 1;
        while (j <= 100)
        {
            if (j % 3 == 0 && j % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (j % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (j % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(j);
            }
            j++;
        }
    }
}
