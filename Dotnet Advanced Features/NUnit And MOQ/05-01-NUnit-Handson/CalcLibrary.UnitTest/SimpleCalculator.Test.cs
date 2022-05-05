using System;

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
    [TestCase(-10, 0, null)]
    [TestCase(-10, 10, -1)]
    [TestCase(-1000, -10, 100)]
    public void Division_With_CorrectResult(double valA, double valB, double expected)
    {
        try
        {
            calculator!.Division(valA, valB);
            Assert.AreEqual(calculator!.Division(valA, valB), expected);
        }
        catch (ArgumentException)
        {
            Assert.Fail("Division by zero");
        }
    }

    [Test]
    [TestCase(12, 0, 12)]
    [TestCase(0, 0, 0)]
    [TestCase(-10, 10, 0)]
    [TestCase(-1000, -10, -1010)]
    public void TestAddAndClear(double valA, double valB, double expected)
    {
        Assert.AreEqual(calculator!.Addition(valA, valB), expected);

        calculator.AllClear();
        Assert.AreEqual(calculator.GetResult, 0);
    }

}