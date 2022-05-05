using System;
using System.Threading;
// See https://aka.ms/new-console-template for more information
namespace ThreadStartSample2;
public class Printer
{
    public void PrintNumbers()
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