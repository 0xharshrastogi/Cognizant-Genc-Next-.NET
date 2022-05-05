using System;
using System.Threading;
// See https://aka.ms/new-console-template for more information
namespace ThreadStartSample;
public class Printer
{
    public void PrintNumber()
    {
        Console.WriteLine($"-> {Thread.CurrentThread.Name}");

        Console.WriteLine("Your Numbers");

        for (var i = 0; i < 10; i++)
        {
            Console.Write($"{i}");
            Thread.Sleep(2000);
        }

        Console.WriteLine();
    }

}