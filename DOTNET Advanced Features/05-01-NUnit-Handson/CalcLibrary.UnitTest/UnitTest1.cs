using System;
using NUnit.Framework;

namespace CalcLibrary.UnitTest;

public class SimpleCalculatorTest
{
    SimpleCalculator? calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new();
    }

    [Test]
    [TestCase(12, 0, 12)]
    [TestCase(0, 0, 0)]
    [TestCase(-10, 10, 0)]
    [TestCase(-10, 1, -9)]
    public void Addition_With_CorrectSum(double valA, double valB, double expected)
    {
        Assert.That(calculator!.Addition(valA, valB) == expected);
    }

    [Test]
    [TestCase(12, 0, 12)]
    [TestCase(0, 0, 0)]
    [TestCase(-10, 10, -20)]
    [TestCase(-1000, -999, -1)]
    public void Subtraction_With_CorrectDifference(double valA, double valB, double expected)
    {
        Assert.AreEqual(expected, calculator!.Subtraction(valA, valB));
    }

    [Test]
    [TestCase(12, 0, 0)]
    [TestCase(0, 0, 0)]
    [TestCase(-10, 10, -100)]
    [TestCase(-1000, -999, 999000)]
    public void Multiplication_With_CorrectProduct(double valA, double valB, double expected)
    {
        Assert.AreEqual(calculator!.Multiplication(valA, valB), expected);
    }

    [Test]
    [TestCase(12, 0, null)]
    [TestCase(0, 0, null)]
    [TestCase(-10, 10, -1)]
    [TestCase(-1000, -10, 100)]
    public void Division_With_CorrectResult(double valA, double valB, double expected)
    {
        if (valB == 0)
            Assert.Throws<ArgumentException>(() => throw new ArgumentException());
        else
            Assert.AreEqual(calculator!.Division(valA, valB), expected);
    }

    [Test]
    [TestCase(12, 0)]
    [TestCase(0, 0)]
    [TestCase(-10, 10)]
    [TestCase(-1000, -10)]
    public void Test_AllClear_Behaviour(double valA, double valB)
    {
        var expected = 0d;
        calculator!.Addition(valA, valB);
        calculator.AllClear();

        Assert.That(calculator.GetResult == expected);
    }

}