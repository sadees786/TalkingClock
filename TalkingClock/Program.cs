using System;
using TalkingClockRuleEngine;

namespace TalkingClock
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display current time in Human friendly Text

            var time = DateTime.Now.ToString("hh:mm").Split(':');
            Console.WriteLine(ConvertToWords.ConverttoWords(int.Parse(time[0]), int.Parse(time[1])));     
            Console.WriteLine("Please enter a time in the format hh:mm");
            // Check user input if it is in right format
            var timeInput = Console.ReadLine();   
            if(ConvertToWords.ChecktimeFormat(timeInput))
            {
                if (timeInput == null) return;
                var hour = timeInput.Split(':');
                Console.WriteLine(ConvertToWords.ConverttoWords(int.Parse(hour[0]), int.Parse(hour[1])));
            }
            else
            {
                Console.WriteLine("Please enter time in valid format");
            }
        }
    }
}
