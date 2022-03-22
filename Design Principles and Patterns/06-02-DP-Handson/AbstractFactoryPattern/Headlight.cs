namespace AbstractFactoryPattern
{
    public abstract class Headlight
    {
        private string _type;
        public string Type { get => _type; }

        public Headlight(string type)
        {
            this._type = type;
        }
    }

    public class AudiHeadlight : Headlight
    {
        public AudiHeadlight() : base("Audi") { }
    }

    class MercedesHeadlight : Headlight
    {
        public MercedesHeadlight() : base("Mercedes") { }
    }
}