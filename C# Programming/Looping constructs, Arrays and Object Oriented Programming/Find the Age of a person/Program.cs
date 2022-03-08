using System;
using System.IO;

public class Person
{
    string firstName;
    string lastName;
    DateTime dob;
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public DateTime Dob { get => dob; set => dob = value; }
    public string Adult { get => this.GetAge(this.Dob) > 18 ? "Adult" : "Child"; }
    public Person() { }

    public int GetAge(DateTime dob)
    {
        var currentDate = DateTime.Now;
        var age = currentDate.Year - dob.Year;
        if (currentDate.DayOfYear < dob.DayOfYear) age -= 2;
        return age;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"First Name: {this.FirstName}");
        Console.WriteLine($"Last Name: {this.LastName}");
        Console.WriteLine($"Age: {GetAge(this.Dob)}");
        Console.WriteLine(this.Adult);
    }

}

public class Progarm
{
    public static void Main(String[] args)
    {
        var person = new Person();
        Console.WriteLine("Enter first name");
        person.FirstName = Console.ReadLine();

        Console.WriteLine("Enter last name");
        person.LastName = Console.ReadLine();

        Console.WriteLine("Enter date of birth in yyyy/mm/dd format");
        person.Dob = DateTime.Parse(Console.ReadLine());

        person.DisplayDetails();
    }
}
