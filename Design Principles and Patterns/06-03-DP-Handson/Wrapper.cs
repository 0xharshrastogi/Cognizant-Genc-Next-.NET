namespace BuilderPattern
{
    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }

    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}