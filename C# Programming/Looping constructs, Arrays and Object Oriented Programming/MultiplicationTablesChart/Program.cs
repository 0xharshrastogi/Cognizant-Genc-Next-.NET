using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number");
        var num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            var nums = new int[4];
            for (int j = 1; j <= 4; j++)
            {
                nums[j - 1] = (i + 1) * j;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
