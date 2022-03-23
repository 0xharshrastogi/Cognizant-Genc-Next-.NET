namespace SOLID_Principles
{

    public enum ActionType { Order, Repair }
    class Order : IOrder
    {
        public void ProcessOrder(string modelName)
        {
            Console.WriteLine($"{modelName} order accepted!");
        }
    }

    class Repair : IRepair
    {
        public void ProcessAccessory(string type)
        {
            Console.WriteLine($"{type} repair accepted!");

        }

        public void ProcessPhone(string type)
        {
            Console.WriteLine($"{type} repair accepted!");
        }
    }
}
