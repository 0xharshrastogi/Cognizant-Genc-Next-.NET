using NUnit.Framework;
using SeasonsLib;

namespace FourSeasonsLib.UnitTest;

public class SeasonsTest
{
    SeasonTeller? seasonTeller;


    [SetUp]
    public void Setup()
    {
        seasonTeller = new();
    }

    [Test]
    [TestCase("February", "Spring")]
    [TestCase("June", "Summer")]
    [TestCase("December", "Winter")]
    [TestCase("Falenger", "Invalid Season")]
    public void DisplaySeasonName_WithVariousMonthName(string monthName, string expected)
    {
        Assert.AreEqual(seasonTeller!.DisplaySeasonBy(monthName), expected);
    }
}