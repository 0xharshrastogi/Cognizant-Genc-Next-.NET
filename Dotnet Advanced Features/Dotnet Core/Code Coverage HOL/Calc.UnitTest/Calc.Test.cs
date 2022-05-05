using NUnit.Framework;

namespace Calc.UnitTest;

public class CalcTest
{
    Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new();
    }

    [Test]
    public void Add_WhenBothNumberGreaterThanZero_ReturnSum()
    {
        Assert.AreEqual(_calculator.Add(10, 20), 30);
    }

    [Test]
    public void Add_WhenNumAGreaterThanZeroAndNumBLessThanZero_ReturnMinusOne()
    {
        Assert.AreEqual(_calculator.Add(10, -20), -1);
    }

    [Test]
    public void Add_WhenNumALessThanZeroAndNumBGreaterThanZero_ReturnMinusTwo()
    {
        Assert.AreEqual(_calculator.Add(10, -20), -2);
    }

    [Test]
    public void Add_BothNumAreNegative_ReturnZero()
    {
        Assert.AreEqual(_calculator.Add(10, -20), 0);
    }
}