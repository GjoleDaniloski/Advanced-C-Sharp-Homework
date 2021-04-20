using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holidayDays = new List<DateTime>()
            { 
                new DateTime(DateTime.Now.Year, 1, 1),
                new DateTime(DateTime.Now.Year, 1, 7),
                new DateTime(DateTime.Now.Year, 4, 20),
                new DateTime(DateTime.Now.Year, 6, 1),
                new DateTime(DateTime.Now.Year, 6, 25),
                new DateTime(DateTime.Now.Year, 8, 3),
                new DateTime(DateTime.Now.Year, 9, 8),
                new DateTime(DateTime.Now.Year, 10, 12),
                new DateTime(DateTime.Now.Year, 10, 23),
                new DateTime(DateTime.Now.Year, 12, 8)
            
            };

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a day");
                    int inputDay = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter a month");
                    int inputMonth = int.Parse(Console.ReadLine());

                    var inputDate = $"{inputDay}{inputMonth}";

                    DateTime convertedToString = new DateTime(2021, inputMonth, inputDay);
                    string day = convertedToString.ToString("dddd");

                    Console.WriteLine($"The day is {day}");

                    if (day == "Saturday" || day == "Sunday")
                    {
                        Console.WriteLine("The day isn't working day, enjoy in weekend days");
                        continue;
                    }
                    else if (holidayDays.Contains(convertedToString))
                    {
                        Console.WriteLine("The day isn't working day, enjoy in holiday days");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("The day is working day");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorect date format, try again");
                    continue;
                }
                
            }
            
        }

        
    }
}
