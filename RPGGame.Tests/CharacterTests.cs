using RPGGame.Models;
using Xunit;
namespace RPGGame.Tests;

public class CharacterTests
{
    [Fact]
    public void Character_Should_Have_Name_Health_AttackPower_And_Defense()
    {
        string name = "Hero";
        int health = 100;
        int attackPower = 20;
        int defense = 5;

        var character = new Character(name, health, attackPower, defense);

        Assert.Equal(name, character.Name);
        Assert.Equal(health, character.Health);
        Assert.Equal(attackPower, character.AttackPower);
        Assert.Equal(defense, character.Defense);
    }

    [Fact]
    public void Character_Should_Not_Lose_Health_If_Defense_Is_Higher_Than_Attack()
    {
        var hero = new Character("Hero", 100, 5, 10);
        var orc = new Character("Orc", 50, 3, 15);

        hero.Attack(orc);

        Assert.Equal(50, orc.Health);
    }
}