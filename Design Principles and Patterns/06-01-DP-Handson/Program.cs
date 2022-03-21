namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            var factory = FactoryMaker.CreateFactory(FactoryType.audi);
            var headlight = factory?.makeHeadLight();
            var tire = factory?.makeTire();
        }
    }
}