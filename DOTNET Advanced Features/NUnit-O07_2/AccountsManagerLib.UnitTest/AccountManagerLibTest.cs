using System;
using NUnit.Framework;

namespace AccountsManagerLib.UnitTest;

public class AccountsManagerTest
{
    AccountsManager? manager;

    [SetUp]
    public void Setup()
    {
        manager = new();
    }

    [Test]
    [TestCase("user_11", "secret@user11")]
    [TestCase("user_22", "secret@user22")]
    public void ValidateUser_WithValidaCredential_LoginSuccessfull(string userId, string password)
    {
        var result = manager!.ValidateUser(userId, password);
        var expected = $"Welcome {userId}!!!";
        Assert.AreEqual(result, expected);
    }

    [Test]
    [TestCase("user_33", "secret@user44")]
    [TestCase("user_44", "secret@user44")]
    public void ValidateUser_WithInValidaCredential_LoginFailed(string userId, string password)
    {
        var result = manager!.ValidateUser(userId, password);
        var expected = "Invalid user id/password";
        Assert.AreEqual(result, expected);
    }

    [Test]
    [TestCase("", "secret@user44")]
    [TestCase("user_44", "")]
    [TestCase("user_11", null)]
    [TestCase(null, "")]
    public void ValidateUser_WithEmptyUserIdOrPassword_LoginFailed(string userId, string password)
    {
        Assert.Catch(typeof(FormatException), () =>
        {
            var result = manager!.ValidateUser(userId, password);
        });
    }
}