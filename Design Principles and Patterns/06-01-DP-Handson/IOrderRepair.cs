namespace SOLID_Principles
{
    interface IOrder
    {
        void ProcessOrder(string modelName);
    }

    interface IRepair
    {
        void ProcessAccessory(string accessoryType);
        void ProcessPhone(string modelName);
    }
}
