using System;
using NUnit.Framework;

[TestFixture]
public class UnitTest
{
    private Program _account;

    [SetUp]
    public void Setup()
    {
        // Initializing with a base balance of 100 for consistent testing
        _account = new Program(100m);
    }

    [Test]
    public void Test_Deposit_ValidAmount()
    {
        _account.Deposit(50m);
        // Assert: 100 + 50 = 150
        Assert.AreEqual(150m, _account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        // Assert: Checks if the specific exception message is thrown
        var ex = Assert.Throws<Exception>(() => _account.Deposit(-10m));
        Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        _account.Withdraw(40m);
        // Assert: 100 - 40 = 60
        Assert.AreEqual(60m, _account.Balance);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        // Assert: Checks if the specific exception message is thrown when amount > balance
        var ex = Assert.Throws<Exception>(() => _account.Withdraw(200m));
        Assert.AreEqual("Insufficient funds.", ex.Message);
    }
}
