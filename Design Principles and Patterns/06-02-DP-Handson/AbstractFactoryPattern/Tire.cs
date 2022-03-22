namespace AbstractFactoryPattern
{
    public abstract class Tire
    {
        private string _type;
        public string Type { get => _type; }

        public Tire(string type)
        {
            this._type = type;
        }
    }

    class AudiTire : Tire
    {
        public AudiTire() : base("Audi") { }
    }

    class MercedesTire : Tire
    {
        public MercedesTire() : base("Mercedes") { }
    }
}