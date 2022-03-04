using Internal;
using System;

public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter name");
    var userName = Console.ReadLine();

    Console.WriteLine("Enter age(completed years and months)");
    var userAge = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"Enter gender('M' for Male and 'F' for Female)");
    var gender = Console.ReadLine();

    Console.WriteLine($"Enter city");
    var city = Console.ReadLine();

    Console.WriteLine($"Enter mobile number");
    var mobileNumber = Console.ReadLine();

    Console.WriteLine($"Enter pincode");
    var pincode = Console.ReadLine();

    Console.WriteLine($"Name:\t{userName}");
    Console.WriteLine();
    Console.WriteLine($"Age:\t{userAge}");
    Console.WriteLine();
    Console.WriteLine($"Gender:\t{gender}");
    Console.WriteLine();
    Console.WriteLine($"City:\t{city}");
    Console.WriteLine();
    Console.WriteLine($"Mobile:\t{mobileNumber}");
    Console.WriteLine();
    Console.WriteLine($"Pincode:\t{pincode}");
  }
}
