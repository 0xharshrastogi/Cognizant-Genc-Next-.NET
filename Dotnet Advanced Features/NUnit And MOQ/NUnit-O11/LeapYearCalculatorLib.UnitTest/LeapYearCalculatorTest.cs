using NUnit.Framework;

namespace LeapYearCalculatorLib.UnitTest;

public class LeapYearCalculatorTest
{
    LeapYearCalculator? calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new();
    }

    [Test]
    [TestCase(1752, -1)]
    [TestCase(1753, 0)]
    [TestCase(1754, 0)]
    [TestCase(2000, 1)]
    [TestCase(2001, 0)]
    [TestCase(9998, 0)]
    [TestCase(9999, 0)]
    [TestCase(10000, -1)]
    public void IsLeapYear__TestAtBoundaryValues(int year, int expected)
    {
        Assert.AreEqual(calculator!.IsLeapYear(year), expected);
    }
}