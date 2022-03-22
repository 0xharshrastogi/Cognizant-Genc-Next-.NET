namespace AbstractFactoryPattern
{
    public interface IFactory
    {
        Headlight MakeHeadlight();
        Tire MakeTire();
    }
}