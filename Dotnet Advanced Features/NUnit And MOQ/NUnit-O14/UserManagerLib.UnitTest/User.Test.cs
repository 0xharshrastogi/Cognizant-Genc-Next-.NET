using System;
using NUnit.Framework;

namespace UserManagerLib.UnitTest;

public class UserTest
{
    User? user;

    [SetUp]
    public void Setup()
    {
        user = new();
    }

    [Test]
    [TestCase("FKLSM9392")]
    [TestCase("FKLSM9392SD")]
    [TestCase("FDSK92SD12")]
    public void ValidatePANCardNumber_Test(string panNumber)
    {
        try
        {
            Assert.AreEqual(user!.ValidatePANCardNumber(panNumber), "Valid");
        }
        catch (NullReferenceException ex)
        {
            Assert.Fail(ex.Message);
        }
        catch (FormatException ex)
        {
            Assert.Fail(ex.Message);
        }
    }
}