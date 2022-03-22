namespace AbstractFactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            var audiFactory = Factory.FactoryMaker("Audi");
            var mercedesFactory = Factory.FactoryMaker("Mercedes");

            mercedesFactory?.MakeHeadlight();
            mercedesFactory?.MakeTire();
        }
    }
}