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

    public static int singleHourGlassSum(List<List<int>> arr, int i, int j)
    {
        var row1 = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
        var row2 = arr[i + 1][j + 1];
        var row3 = arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

        return row1 + row2 + row3;
    }

    // to provide min value;
    public static int hourglassSum(List<List<int>> arr)
    {
        var max = double.NegativeInfinity;

        for (var i = 0; i < arr.Count() - 2; i++)
            for (var j = 0; j < arr[i].Count() - 2; j++)
            {
                var sum = singleHourGlassSum(arr, i, j);
                max = sum > max ? sum : max;
            }

        return max;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
