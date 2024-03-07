using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of attacks
        Attack fireball = new Attack("Fireball", 20);
        Attack punch = new Attack("Punch", 15);
        Attack kick = new Attack("Kick", 25);

        // Creating an instance of enemy
        Enemy bandit = new Enemy("Bandit");

        // Adding attacks to the enemy's attack list
        bandit.AddAttack(fireball);
        bandit.AddAttack(punch);
        bandit.AddAttack(kick);

        // Testing random attack
        bandit.RandomAttack();
    }
}

