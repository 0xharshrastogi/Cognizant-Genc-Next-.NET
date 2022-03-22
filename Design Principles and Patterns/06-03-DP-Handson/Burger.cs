namespace BuilderPattern
{
    public abstract class Burger : IItem
    {
        public abstract string Name();

        public IPacking packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }

    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 25f;
        }
    }

    public class NonVegBurger : Burger
    {
        public override string Name()
        {
            return "Non Veg Burger";
        }

        public override float Price()
        {
            return 30f;
        }
    }

    public class ChickenBurger : NonVegBurger
    {

        public override string Name()
        {
            return "Chicken Burger";
        }
        public override float Price()
        {
            return base.Price() + 5f;
        }
    }
}