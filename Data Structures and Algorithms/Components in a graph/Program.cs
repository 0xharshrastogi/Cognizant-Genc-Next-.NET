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
    public static List<int> componentsInGraph(List<List<int>> gb)
    {
        int[] result = new int[2];
        int[] parents = new int[30001];

        int cnt = gb.Count();
        int a, b;
        int i = 0;

        for (int n = 0; n < cnt; n++)
        {

            a = gb[n][0];
            b = gb[n][1];

            Console.WriteLine(a + " " + b);

            if (parents[a] == 0) parents[a] = a;
            if (parents[b] == 0) parents[b] = a;

            //Disjoin set idea, keep updating the representative element of each set.
            if (parents[a] != 0 || parents[b] != 0)
            {
                int low = Math.Min(parents[a], parents[b]);
                int high = Math.Max(parents[a], parents[b]);
                for (i = 0; i < parents.Length; i++)
                {
                    if (parents[i] == high)
                        parents[i] = low;
                }
            }
        }

        int min = int.MaxValue;
        int max = int.MinValue;
        Dictionary<int, int> frequencies = parents.GroupBy(e => e).ToDictionary(x => x.Key, x => x.Count());
        foreach (KeyValuePair<int, int> frequency in frequencies)
        {
            if (frequency.Key != 0)
            {
                min = Math.Min(min, frequency.Value);
                max = Math.Max(max, frequency.Value);
            }
        }
        Console.WriteLine(min + " " + max);

        result[0] = min;
        result[1] = max;

        return result.ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> gb = new List<List<int>>();

        for (int i = 0; i < n; i++)
            gb.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(gbTemp => Convert.ToInt32(gbTemp)).ToList());

        List<int> result = Result.componentsInGraph(gb);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}