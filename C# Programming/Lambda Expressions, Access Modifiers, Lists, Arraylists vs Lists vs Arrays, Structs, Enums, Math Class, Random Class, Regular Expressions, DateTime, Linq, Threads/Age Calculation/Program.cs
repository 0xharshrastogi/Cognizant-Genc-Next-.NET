using System.Linq;
using System;

namespace DateEx1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            var dobText = Console.ReadLine();
            var age = calculateAge(dobText);
            Console.WriteLine(age);
        }

        public static int calculateAge(string dateOfBirth)
        {
            var timespan = DateTime.Now - DateTime.Parse(String.Join("-", dateOfBirth.Split("-").Reverse()));
            return timespan.Days / 365;
        }
    }
}