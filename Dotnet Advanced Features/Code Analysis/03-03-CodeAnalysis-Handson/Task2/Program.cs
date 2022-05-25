namespace Task2
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a N value to print");
            int num = int.Parse(Console.ReadLine()!);

            int i = 0;
            while (i < num)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}