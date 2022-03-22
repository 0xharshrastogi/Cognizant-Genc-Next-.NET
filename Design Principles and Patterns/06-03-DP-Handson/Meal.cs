namespace BuilderPattern
{
    public class Meal
    {
        public List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public float Cost
        {
            get { return items.Sum((item) => item.Price()); }
        }

        public void Show()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine($"Item: {item.Name()}");
                Console.WriteLine($"Packing: {item.packing().Pack()}");
                Console.WriteLine($"Price: {item.Price()}");
            }
        }
    }
}