using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter your name: ");
      var userName = Console.ReadLine();

      Console.WriteLine("Enter your age: ");
      var userAge = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter your country: ");
      var userCountry = Console.ReadLine();

      Console.WriteLine($"Welcome {userName}. Your age is {userAge} and you are from {userCountry}");
    }
  }
}
