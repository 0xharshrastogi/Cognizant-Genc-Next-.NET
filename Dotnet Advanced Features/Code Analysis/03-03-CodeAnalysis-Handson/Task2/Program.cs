namespace Task2
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a N value to print");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}