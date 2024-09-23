namespace RPGGame.Models;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public Character(string name, int health, int attackPower, int defense)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        Defense = defense;
    }

    public void Attack(Character target)
    {
        int damage = AttackPower - target.Defense;
        if (damage > 0)
        {
            target.Health -= damage;
        }
    }
}