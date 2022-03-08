using System;
using System.Collections.Generic;

namespace DateEx2
{
    public class Program
    {
        static Dictionary<string, DateTime> flightSchedule = new Dictionary<string, DateTime>(){
                                                        {"ZW346", Convert.ToDateTime("13:54:10")},
                                                        {"AT489", Convert.ToDateTime("16:30:00")},
                                                        {"BR267", Convert.ToDateTime("21:15:30")}};


        public static void Main(string[] args)
        {
            Console.Write("Enter the Flight Number :\t");
            var flightNum = Console.ReadLine();

            Console.WriteLine($"\n{flightStatus(flightNum)}");

        }

        public static string flightStatus(string flightNo)
        {
            var departure = flightSchedule.GetValueOrDefault(flightNo);
            var timeLeft = departure - DateTime.Now;

            return timeLeft < new TimeSpan() ? "Flight Already Left" : $"Time To Flight {timeLeft}";
        }
    }
}
