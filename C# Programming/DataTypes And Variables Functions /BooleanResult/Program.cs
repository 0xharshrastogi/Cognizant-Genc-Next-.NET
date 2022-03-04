using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the value for x");
    var x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the value for y");
    var y = Convert.ToDouble(Console.ReadLine());

    var result = x < y;
    Console.WriteLine($"x is less than y  is {result.ToString().ToLower()}");
  }
}
