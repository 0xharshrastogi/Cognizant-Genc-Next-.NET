namespace AbstractFactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            var audiFactory = (AudiFactory?)Factory.FactoryMaker("Audi");
            var mercedesFactory = (MercedesFactory?)Factory.FactoryMaker("Mercedes");

            mercedesFactory?.MakeHeadlight();
            mercedesFactory />
        }
    }
}