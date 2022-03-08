using Internal;
using System;
public class Game
{
  public string Name { get; set; }
  public int MaxNumPlayers { get; set; }

  public Game() { }
  public Game(string name, int maxPlayerCount)
  {
    this.Name = name;
    this.MaxNumPlayers = maxPlayerCount;
  }

  public override string ToString()
  {
    return $"Maximum number of players for {this.Name} is {this.MaxNumPlayers}";
  }
}

public class GameWithTimeLimit : Game
{
  public int TimeLimit { get; set; }

  public GameWithTimeLimit() { }
  public GameWithTimeLimit(string name, int playerCount, int timeLimit) : base(name, playerCount)
  {
    this.TimeLimit = timeLimit;
  }

  public override string ToString()
  {
    Console.WriteLine(base.ToString());
    return $"Time Limit for {this.Name} is {this.TimeLimit} minutes";
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter a game");
    var nameOfGame = Console.ReadLine();

    Console.WriteLine("Enter the maximum number of players");
    var playerCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a game that has time limit");
    var nameOfGameWithTime = Console.ReadLine();

    Console.WriteLine("Enter the maximum number of players");
    var playerCountWithTime = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the time limit in minutes");
    var timeLimit = int.Parse(Console.ReadLine());

    var cricket = new Game(nameOfGame, playerCount);
    var footbaal = new GameWithTimeLimit(nameOfGameWithTime, playerCountWithTime, timeLimit);

    Console.WriteLine(cricket);
    Console.WriteLine(footbaal);

  }
}