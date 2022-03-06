using Internal;
using System;


namespace JaggedArray
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of teams:");
      var teamsCount = Convert.ToInt16(Console.ReadLine());

      var scoreDetails = new int[teamsCount][];

      for (var i = 0; i < teamsCount; i++)
      {
        Console.WriteLine($"No.of attempts for team {i}:");
        var attempCount = Convert.ToInt32(Console.ReadLine());
        scoreDetails[i] = new int[attempCount];
      }

      for (var i = 0; i < teamsCount; i++)
      {
        Console.WriteLine($"Enter the score for team {i + 1}:");
        for (var j = 0; j < scoreDetails[i].Length; j++)
          scoreDetails[i][j] = Convert.ToInt32(Console.ReadLine());
      }

      Console.WriteLine(GetTotalScore(scoreDetails));
    }

    public static int CalcTotal(int[] nums)
    {
      var total = 0;
      foreach (var num in nums)
        total += num;
      return total;
    }

    public static String GetTotalScore(int[][] teamScores)
    {
      var result = new string[teamScores.Length];

      for (var i = 0; i < teamScores.Length; i++)
      {
        result[i] = $"Team {i + 1} Total Score is {CalcTotal(teamScores[i])}";
      }

      return String.Join(" . ", result);
    }

  }
}
