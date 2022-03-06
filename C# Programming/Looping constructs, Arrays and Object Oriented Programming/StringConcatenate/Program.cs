using System;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter first name");
    var fname = Console.ReadLine();

    Console.WriteLine("Enter last name");
    var lname = Console.ReadLine();

    var fullname = string.Concat(fname, " ", lname);
    Console.WriteLine($"Full name : {fullname}");
  }
}
