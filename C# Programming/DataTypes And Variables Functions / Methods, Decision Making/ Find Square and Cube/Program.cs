using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var num = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"Square of {num} is {FindSquare(num)}");
      Console.WriteLine($"Cube of {num} is {FindCube(num)}");
    }
    public static double FindSquare(double num)
    {
      return Math.Pow(num, 2);
    }
    public static double FindCube(double num)
    {
      return Math.Pow(num, 3);
    }
  }
}
