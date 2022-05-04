using System;
using System.IO;
using MagicFilesLib;
using NUnit.Framework;

[TestFixture]
public class ClassName
{
    static readonly string file1 = "file.txt";
    static readonly string file2 = "file2.txt";


    [OneTimeSetUp]
    public static void TestSetup()
    {
        Directory.CreateDirectory("./TestDir");
        File.Create($"./TestDir/{file1}");
        File.Create($"./TestDir/{file2}");
    }

    [Test]
    public void GetFiles_AllFile()
    {
        var dir = new DirectoryExplorer();
        var files = dir.GetFiles("./TestDir");

        foreach (var file in files)
        {
            Console.WriteLine(file);
        }

        Assert.That(files.Contains($"./TestDir/{file1}"));
        Assert.That(files.Contains($"./TestDir/{file2}"));
    }

    [OneTimeTearDown]
    public void TestEnd()
    {
        File.Delete($"./TestDir/{file1}");
        File.Delete($"./TestDir/{file2}");
        Directory.Delete("./TestDir");
    }
}