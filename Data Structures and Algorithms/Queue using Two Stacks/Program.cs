using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Stack<int> inStack = new Stack<int>(),
                   outStack = new Stack<int>();

        int numQueries = int.Parse(Console.ReadLine());

        for (int i = 0; i < numQueries; i++)
        {
            string input = Console.ReadLine();
            switch (input[0])
            {
                case '1':
                    inStack.Push(int.Parse(input.Split(' ')[1]));
                    break;
                case '2': // dequeue (pop the outStack)
                    if (outStack.Count == 0)
                        while (inStack.Count > 0)
                            outStack.Push(inStack.Pop());
                    outStack.Pop();
                    break;
                case '3':
                    if (outStack.Count == 0)
                        while (inStack.Count > 0)
                            outStack.Push(inStack.Pop());
                    Console.WriteLine(outStack.Peek());
                    break;
            }
        }
    }
}