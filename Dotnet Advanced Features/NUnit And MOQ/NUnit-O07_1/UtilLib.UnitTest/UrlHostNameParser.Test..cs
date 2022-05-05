using System;
using NUnit.Framework;

namespace UtilLib.UnitTest;

public class UrlHostNameParserTests
{
    UrlHostNameParser? parser;

    [SetUp]
    public void TestInitialise()
    {
        parser = new();
    }

    [Test]
    [TestCase("https://www.youtube.com/watch?v=ClkQA2Lb_iE", "www.youtube.com")]
    [TestCase("http://youtu.be/ClkQA2Lb_iE", "youtu.be")]
    [TestCase("http://www.example.com/12xy45", "www.example.com")]
    [TestCase("https://example.com/random", "example.com")]
    public void ParseHostName_Test_WithUrls(string url, string expectedHostname)
    {
        try
        {
            var hostname = parser!.ParseHostName(url);
            Assert.AreEqual(hostname, expectedHostname);
        }
        catch (FormatException ex)
        {
            Assert.Fail(ex.Message);
        }
    }
}