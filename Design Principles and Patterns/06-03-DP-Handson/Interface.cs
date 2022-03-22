namespace BuilderPattern
{
    public interface IItem
    {
        public string Name();
        public IPacking packing();
        public float Price();
    }

    public interface IPacking { public string Pack(); }
}