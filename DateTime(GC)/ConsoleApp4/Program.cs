using System;
namespace DateTimeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Date in (mm/dd/yyyy) format: ");
            string date1Str = Console.ReadLine(); // Reading first date as string
            DateTime date1;
            DateTime.TryParse(date1Str, out date1); 

            Console.WriteLine("Enter second Date in (mm/dd/yyyy) format: ");
            string date2Str = Console.ReadLine(); // Reading second date as string
            DateTime date2;
            DateTime.TryParse(date2Str, out date2); 

            TimeSpan span = (date2 - date1); 

            // Using span object built above to print the time difference in
            // terms of days, hours, and minutes
            string formattedTimeDif = string.Format(
                                                "Time difference in days: {0} days.\nTime difference in hours: {1} hours.\nTime difference in minutes: {2} minutes.\n",
                                                span.Days,
                                                span.Days * 24, // computing hours using number of days
                                                span.Days * 24 * 60);// computing minutes using number of days

            Console.WriteLine(formattedTimeDif);

            Console.ReadLine();
        }
    }
}