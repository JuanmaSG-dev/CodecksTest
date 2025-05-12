using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class NinjaFrog
{
    private NinjaFrogStats stats;
    [SetUp]
    public void SetUp()
    {
        stats = new NinjaFrogStats(); 
    }

    [Test] 
    public void DefaultLives_ShouldBeThree()
    {
        Assert.AreEqual(3, stats.maxLives, "The default lives should be " + 3 + " but was " + stats.maxLives);
    }

    // Case Test for power and range
    [TestCase(true, 1, 1)]
    [TestCase(true, 2, 1)]
    [TestCase(false, 0, 1)]
    [TestCase(false, 1, 0)]
    [TestCase(true, 1, 0)]
    public void AttackPower_Cases(bool expected, int attackPower, int attackRange)
    {
        bool actual = stats.CanAttack(attackPower, attackRange);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }


    // Test Get Fuerza
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(1)]
    public void GetFuerza_Cases(int expected)
    {
        int actual = stats.getFuerza();
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }

    // Test Esta Vivo
    [TestCase(true, 2)]
    [TestCase(true, 3)]
    [TestCase(false, 0)]
    [TestCase(true, -2)]
    public void EstaVivo_Cases(bool expected, int currentHP)
    {
        bool actual = stats.estaVivo(currentHP);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }
}
