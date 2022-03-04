using System;

public class Program
{
  public static void Main()
  {
    sbyte number = 125;
    Console.WriteLine($"Value of number: {number}");
    number = sbyte.MaxValue;
    Console.WriteLine($"Largest value stored in a signed byte:  {number}");
  }
}