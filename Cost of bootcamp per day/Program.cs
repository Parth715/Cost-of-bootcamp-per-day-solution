using System;

namespace Cost_of_bootcamp_per_day
{
    class Program
    {
        static void Main(string[] args)
        {
            var TotalPrice = 15500m;
            var TotalDays = 65;
            var PerDayCost = Math.Round(TotalPrice / TotalDays, 2);
            Console.WriteLine($"Each day of bootcamp will cost ${PerDayCost}");
        }
    }
}
