using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2
{
  public class Program
  {
    const int COST_PER_PIZZA = 200;
    const int COST_PER_PUFF = 40;
    const int COST_PER_PEPSI = 120;

    public static int CalcTotalCost(int pepsiCount, int puffCount, int pizzaCount)
    {
      return CalcPepsiCost(pepsiCount) + CalcPizzaCost(pizzaCount) + CalcPuffCost(puffCount);
    }
    public static int CalcPizzaCost(int count) => count * COST_PER_PIZZA;
    public static int CalcPepsiCost(int count) => count * COST_PER_PEPSI;
    public static int CalcPuffCost(int count) => count * COST_PER_PUFF;
    public static void Main(string[] args)     //DO NOT change the 'Main' method signature
    {
      Console.WriteLine("Enter the number of pizzas bought :");
      var pizzaCount = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the number of puffs bought :");
      var puffsCount = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the number of pepsi bought :");
      var pepsiCount = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Bill Details");
      Console.WriteLine();

      Console.WriteLine($"Cost of Pizzas :{CalcPizzaCost(pizzaCount)}");
      Console.WriteLine($"Cost of Puffs :{CalcPuffCost(puffsCount)}");
      Console.WriteLine($"Cost of Pepsis :{CalcPepsiCost(pepsiCount)}");

      var totalCost = CalcTotalCost(pepsiCount, puffsCount, pizzaCount);

      Console.WriteLine($"GST 12% : {0.12 * (float)totalCost}");
      Console.WriteLine($"CESS 5% : {0.05 * (float)totalCost}");
      Console.WriteLine($"Total Price:{totalCost}");
    }
  }
}
