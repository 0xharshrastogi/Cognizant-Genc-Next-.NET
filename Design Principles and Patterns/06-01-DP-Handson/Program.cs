namespace SOLID_Principles
{
    class Program
    {
        static int Main(string[] args)
        {
            var repair = new Repair();

            Console.Write("Welcome to our site. Would you like to order or repair?\t");
            var action = Console.ReadLine();

            if (action == null) throw new NullReferenceException();

            switch (action.Trim().ToLower())
            {
                case "order":
                    Console.WriteLine("Please provide the phone model name");
                    var modelName = Console.ReadLine();
                    if (modelName != null) repair.ProcessPhone(modelName);
                    break;

                case "repair":

                    Console.WriteLine("Is it the phone or the accessory that you want to be repaired?");
                    var productType = Console.ReadLine();

                    if (productType == null) throw new InvalidProgramException();

                    if (productType.ToLower() == "phone")
                    {
                        Console.WriteLine("Please provide the phone model name");
                        var phoneModleName = Console.ReadLine()?.Trim();
                        if (string.IsNullOrEmpty(phoneModleName)) throw new InvalidDataException();

                        repair.ProcessPhone(phoneModleName);
                    }
                    else
                    {
                        Console.WriteLine("Please provide the accessory detail, like headphone, tempered glass");

                        var productDetail = Console.ReadLine();

                        if (string.IsNullOrEmpty(productDetail)) throw new InvalidDataException();

                        repair.ProcessAccessory(productDetail);
                    }
                    break;
            }

            Console.WriteLine("Thanks for choosing us. Have a great day.");

            return 0;
        }
    }
}
