using System;

public class Account
{

  int id;
  string accountType = "";
  double balance;
  public int Id { get => this.id; set => this.id = value; }
  public string AccountType { get => accountType; set => accountType = value; }
  public double Balance { get => balance; set => balance = value; }
  public Account() { }
  public Account(int id, string accountType, double balance)
  {
    this.id = id;
    this.accountType = accountType;
    this.balance = balance;
  }

  public bool WithDraw(double amount)
  {
    if (this.balance < amount) return false;
    this.balance -= amount;
    return true;
  }

  public string GetDetails()
  {
    return $"Account Id: {this.id}\nAccount Type: {this.accountType}\nBalance: {this.balance}";
  }

}

class Program
{
  public static void Main(string[] args)
  {
    var acc = new Account();

    Console.WriteLine("Enter account id");
    acc.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter account type");
    acc.AccountType = Console.ReadLine();
    Console.WriteLine("Enter account balance");
    acc.Balance = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter amount to withdraw");
    var amountToWithDrawn = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(acc.GetDetails());

    if (acc.WithDraw(amountToWithDrawn))
      Console.WriteLine($"New Balance : {acc.Balance}");
  }
}