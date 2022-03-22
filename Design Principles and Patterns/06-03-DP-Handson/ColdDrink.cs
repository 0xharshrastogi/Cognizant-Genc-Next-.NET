namespace BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();

        public IPacking packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }

    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 30.0f;
        }
    }

    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 29.0f;
        }
    }
}