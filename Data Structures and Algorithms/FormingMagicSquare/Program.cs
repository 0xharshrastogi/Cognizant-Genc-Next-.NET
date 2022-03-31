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
    public static int formingMagicSquare(List<List<int>> s)
    {
        List<int[,]> squares = new List<int[,]>
            {
                square1,
                square2,
                square3,
                square4,
                square5,
                square6,
                square7,
                square8
            };
        int min = int.MaxValue;
        for (var S = 0; S < squares.Count; S++)
        {
            int tempMin = 0;
            for (int i = 0; i < 3 && tempMin < min; i++)
            {
                for (int j = 0; j < 3 && tempMin < min; j++)
                {
                    tempMin += Math.Abs(s[i][j] - squares[S][i, j]);
                }
            }

            min = tempMin < min ? tempMin : min;
        }
        return min;

    }

    static int[,] square1 = {
            { 8, 1, 6 },
            { 3, 5, 7 },
            { 4, 9, 2 }
        };
    static int[,] square2 = {
            { 8, 3, 4 },
            { 1, 5, 9 },
            { 6, 7, 2 }
        };
    static int[,] square3 = {
            { 6, 7, 2 },
            { 1, 5, 9 },
            { 8, 3, 4 }
        };
    static int[,] square4 = {
            { 4, 9, 2 },
            { 3, 5, 7 },
            { 8, 1, 6 }
        };
    static int[,] square5 = {
            { 2, 9, 4 },
            { 7, 5, 3 },
            { 6, 1, 8 }
        };
    static int[,] square6 = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };
    static int[,] square7 = {
            { 4, 3, 8 },
            { 9, 5, 1 },
            { 2, 7, 6 }
        };
    static int[,] square8 = {
            { 6, 1, 8 },
            { 7, 5, 3 },
            { 2, 9, 4 }
        };
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
