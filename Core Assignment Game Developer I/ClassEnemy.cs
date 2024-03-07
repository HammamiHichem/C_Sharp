using System;
using System.Collections.Generic;

public class Enemy
{
    public string Name { get; }
    private int Health { get; set; }
    private List<Attack> AttackList { get; }

    public int EnemyHealth { get { return Health; } }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public void AddAttackToList(string name, int damageAmount)
    {
        Attack newAttack = new Attack(name, damageAmount);
        AttackList.Add(newAttack);
    }

    public void RandomAttack()
    {
        Random random = new Random();
        int index = random.Next(AttackList.Count);
        Attack attack = AttackList[index];
        Console.WriteLine($"The {Name} enemy attacks with {attack.Name} for {attack.DamageAmount} damage!");
    }
}
