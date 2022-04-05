using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static string isBalanced(string s)
    {
        var stack = new Stack<char>();

        foreach (var symbol in s)
        {
            switch (symbol)
            {
                case '{':
                case '(':
                case '[':
                    stack.Push(symbol);
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Peek() != '{') return "NO";
                    stack.Pop();
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Peek() != '(') return "NO";
                    stack.Pop();
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Peek() != '[') return "NO";
                    stack.Pop();
                    break;
                default:
                    break;
            }
        }
        return stack.Count == 0 ? "YES" : "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
