using NUnit.Framework;

namespace ConverterLib.UnitTest;

public class Tests
{
    Converter? converter;
    [SetUp]
    public void Setup()
    {
        converter = new();
    }

    [Test]
    [TestCase(0, 275.15)]
    [TestCase(100, 375.15)]
    public void CelsiusToKelvin_Test(double tempInCelcius, double expected)
    {
        Assert.That(
            converter!.CelsiusToKelvin(tempInCelcius),
            Is.EqualTo(expected).Within(15).Percent
        );
    }

    [Test]
    [TestCase(100, 220.5)]
    public void KilogramToPound_Test(double kilogram, double expected)
    {
        Assert.That(converter!.KilogramToPound(kilogram), Is.EqualTo(expected).Within(10).Percent);
    }

    [Test]
    [TestCase(1.609, 1)]
    public void KilometerToMile_Test(double kilometer, double expected)
    {
        Assert.That(converter!.KilometerToMile(kilometer), Is.EqualTo(expected).Within(10).Percent);
    }

    [Test]
    [TestCase(3.785, 1)]
    public void LiterToGallon__Test(double liter, double expected)
    {
        Assert.That(converter!.LiterToGallon(liter), Is.EqualTo(expected).Within(10).Percent);
    }


    [Test]
    [TestCase(1, 0.945996)]
    public void USDToEuro__Test(double doller, double expected)
    {
        Assert.That(converter!.USDToEuro(doller), Is.EqualTo(expected).Within(10).Percent);
    }
}