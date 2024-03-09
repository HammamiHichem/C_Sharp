using System;

public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public Attack[] Attacks { get; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100; // Default health for enemy
        Attacks = new Attack[]
        {
            new Attack("Slap", 15),
            new Attack("Bite", 20),
            new Attack("Scratch", 25),
            new Attack("Heal", -20) // Negative value for healing
        };
    }

    public Attack ChooseAttack()
    {
        Random rand = new Random();
        int index = rand.Next(Attacks.Length);
        return Attacks[index];
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
