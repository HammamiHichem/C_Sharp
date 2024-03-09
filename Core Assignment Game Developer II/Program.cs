using System;
using System.Collections.Generic;

public class Attack
{
    public string Name { get; }
    public int DamageAmount { get; set; }

    public Attack(string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
    }
}

public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; }

    public const int MaxHealth = 100;

    public Enemy(string name)
    {
        Name = name;
        Health = MaxHealth;
        AttackList = new List<Attack>();
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public virtual void PerformAttack(Enemy target, Attack chosenAttack)
    {
        target.Health -= chosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {target.Name}, dealing {chosenAttack.DamageAmount} damage. {target.Name}'s health is now {target.Health}.");
    }
}

public class Melee : Enemy
{
    public Melee(string name) : base(name)
    {
        Health = 120;
        AddAttack(new Attack("Punch", 20));
        AddAttack(new Attack("Kick", 15));
        AddAttack(new Attack("Tackle", 25));
    }

    public void Rage()
    {
        Random random = new Random();
        int index = random.Next(AttackList.Count);
        Attack chosenAttack = AttackList[index];
        chosenAttack.DamageAmount += 10;
        PerformAttack(this, chosenAttack);
    }
}

public class Ranged : Enemy
{
    public int Distance { get; set; }

    public Ranged(string name) : base(name)
    {
        Health = 100;
        Distance = 5;
        AddAttack(new Attack("Shoot an Arrow", 20));
        AddAttack(new Attack("Throw a Knife", 15));
    }

    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (Distance >= 10)
        {
            base.PerformAttack(target, chosenAttack);
        }
        else
        {
            Console.WriteLine($"{Name} cannot perform the attack as the target is too close.");
        }
    }

    public void Dash()
    {
        Distance = 20;
    }
}

public class Magic : Enemy
{
    public Magic(string name) : base(name)
    {
        Health = 80;
        AddAttack(new Attack("Fireball", 25));
        AddAttack(new Attack("Lightning Bolt", 20));
        AddAttack(new Attack("Staff Strike", 10));
    }

    public void Heal(Enemy target)
    {
        target.Health += 40;
        if (target.Health > MaxHealth)
        {
            target.Health = MaxHealth;
        }
        Console.WriteLine($"{Name} heals {target.Name} for 40 health. {target.Name}'s health is now {target.Health}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Melee melee = new Melee("Melee Fighter");
        Ranged ranged = new Ranged("Ranged Fighter");
        Magic magic = new Magic("Magic Caster");

        melee.PerformAttack(ranged, melee.AttackList[0]);
        melee.Rage();
        ranged.PerformAttack(melee, ranged.AttackList[0]);
        ranged.Dash();
        ranged.PerformAttack(melee, ranged.AttackList[0]);
        magic.PerformAttack(melee, magic.AttackList[0]);
        magic.Heal(ranged);
        magic.Heal(magic);
    }
}
