using System;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Attack[] Attacks { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100; // Default health
        Attacks = new Attack[]
        {
            new Attack("Punch", 20),
            new Attack("Kick", 25),
            new Attack("Slash", 30),
            new Attack("Dmeg", 80),
            new Attack("Heal", -25) // Negative value for healing
        };
    }

    public void DisplayAttacks()
    {
        Console.WriteLine("Available Attacks:");
        for (int i = 0; i < Attacks.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Attacks[i].Name}");
        }
    }

    public Attack SelectAttack()
    {
        Console.WriteLine($"{Name}, select your attack:");
        DisplayAttacks();
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Attacks.Length)
        {
            Console.WriteLine("Invalid choice. Please select a valid attack.");
        }
        return Attacks[choice - 1];
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} took {damage} damage. Health: {Health}");
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
