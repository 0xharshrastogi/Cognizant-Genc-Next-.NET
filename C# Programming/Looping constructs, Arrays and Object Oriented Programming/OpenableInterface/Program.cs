using Internal;
using System;
interface IOpenable
{
  public string OpenSeasame();
}

class TreasureBox : IOpenable
{
  public string OpenSeasame() => "Congratulations , Here is your lucky win";
}

class Parachute : IOpenable
{
  public string OpenSeasame() => "Have a thrilling experience flying in air";
}

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter the letter found in the paper");
    var letterInPaper = Console.ReadLine();

    if (letterInPaper == "T") Console.WriteLine(new TreasureBox().OpenSeasame());
    else if (letterInPaper == "P") Console.WriteLine(new Parachute().OpenSeasame());
  }
}