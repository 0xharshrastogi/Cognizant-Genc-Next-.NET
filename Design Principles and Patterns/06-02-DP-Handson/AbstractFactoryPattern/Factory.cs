namespace AbstractFactoryPattern
{
    class Factory
    {
        public static IFactory? FactoryMaker(string type)
        {
            switch (type)
            {
                case "Audi":
                    return new AudiFactory();
                case "Mercedes":
                    return new MercedesFactory();
            }
            return null;
        }
    }
    class AudiFactory : IFactory
    {
        public Headlight MakeHeadlight()
        {
            return new AudiHeadlight();
        }

        public Tire MakeTire()
        {
            return new AudiTire();
        }
    }

    public class MercedesFactory : IFactory
    {
        public Headlight MakeHeadlight()
        {
            return new MercedesHeadlight();
        }

        public Tire MakeTire()
        {
            return new MercedesTire();
        }
    }
}