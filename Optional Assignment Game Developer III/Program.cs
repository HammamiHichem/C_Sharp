using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game!");
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Player player = new Player(playerName);

        Console.WriteLine($"Welcome, {player.Name}!");

        Enemy enemy = new Enemy("Evil Enemy");

        Console.WriteLine($"A wild {enemy.Name} appears!");

        // Game loop
        while (player.IsAlive() && enemy.IsAlive())
        {
            // Player's turn
            Attack playerAttack = player.SelectAttack();
            enemy.TakeDamage(playerAttack.Damage);
            if (!enemy.IsAlive()) break;

            // Enemy's turn
            Attack enemyAttack = enemy.ChooseAttack();
            player.TakeDamage(enemyAttack.Damage);
            if (!player.IsAlive()) break;
        }

        // Declare the winner
        if (player.IsAlive())
        {
            Console.WriteLine("Congratulations! You defeated the enemy!");
        }
        else
        {
            Console.WriteLine("Game over! You were defeated by the enemy.");
        }

        Console.WriteLine("Do you want to play again? (yes/no)");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "yes")
        {
            // Restart the game
            Main(null);
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}
