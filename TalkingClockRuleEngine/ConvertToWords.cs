using System;
using System.Globalization;

namespace TalkingClockRuleEngine
{
    public static class ConvertToWords
    {
        public static string ConverttoWords(int h, int m)
        {
            string[] hours = { "zero", "one", "two", "three", "four",
                            "five", "six", "seven", "eight", "nine",
                            "ten", "eleven", "twelve", "thirteen",
                            "fourteen", "fifteen", "sixteen", "seventeen",
                            "Eighteen", "nineteen", "twenty", "twenty one",
                            "Twenty two", "twenty three", "twenty four",
                            "twenty five", "twenty six", "twenty seven",
                            "twenty eight", "twenty nine",
                        };

            if (m == 0)
                return (char.ToUpper(hours[h][0]) + hours[h].Substring(1)+ " o'clock ");

            if (m == 1)
                return ("One minute past " + hours[h]);

            if (m == 59)
                return ("One minute to " + hours[(h % 12) + 1]);

            if (m == 15)
                return ("Quarter past " + hours[h]);

            if (m == 30)
                return ("Half past " + hours[h]);

            if (m == 45)
                return ("Quarter to " + hours[(h % 12) + 1]);

            if (m <= 30)
                return (hours[m] + " minutes past " + hours[h]);

            return (hours[60 - m] + " minutes to " + hours[(h % 12) + 1]);
        
        }

        public static bool ChecktimeFormat(string inputtime)
        {
            return DateTime.TryParseExact(inputtime, "HH:mm", new CultureInfo("en-GB"), DateTimeStyles.None, out DateTime result);

        }
    }
}

