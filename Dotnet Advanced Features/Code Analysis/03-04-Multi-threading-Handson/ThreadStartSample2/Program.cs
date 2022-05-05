using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread Start Delete App");
            Console.WriteLine("Do you want [1] or [2] threads?");
            string threadCount = Console.ReadLine();

            var primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing Main()");

            var p = new Printer();

            switch (threadCount)
            {
                case "2":
                    var backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
                    break;

                case "1":
                    p.PrintNumbers();
                    break;

                default:
                    Console.WriteLine("you get 1 thread");
                    goto case "1";
            }

            Console.WriteLine("Hello this is from main!");
        }
    }
}