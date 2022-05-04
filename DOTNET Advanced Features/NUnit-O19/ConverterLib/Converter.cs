namespace ConverterLib
{
    public class Converter : IConverter
    {
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double KilogramToPound(double kilogram)
        {
            return kilogram * 2.205;
        }

        public double KilometerToMile(double kilometer)
        {
            return kilometer / 1.609;
        }

        public double LiterToGallon(double liter)
        {
            return liter / 3.785;
        }

        public double USDToEuro(double dollar)
        {
            return 0.945996 * dollar;
        }
    }
}
