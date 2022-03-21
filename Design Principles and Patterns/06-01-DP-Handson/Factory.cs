namespace Program
{
    public enum FactoryType { audi, mercedes }
    public abstract class Factory
    {
        public abstract Headlight makeHeadLight();
        public abstract Tire makeTire();
    }

    class AudiFactory : Factory
    {
        public AudiFactory() { }
        public override Headlight makeHeadLight()
        {
            return new AudiHeadlight();
        }

        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }

    class MercedesFactory : Factory
    {
        public MercedesFactory() { }

        public override Headlight makeHeadLight()
        {
            return new MercedesHeadlight();
        }

        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }

    public class FactoryMaker
    {
        public static Factory? CreateFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.audi:
                    return new AudiFactory();
                case FactoryType.mercedes:
                    return new MercedesFactory();
            }
            return null;
        }
    }
}