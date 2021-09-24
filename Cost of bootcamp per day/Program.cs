using System;

namespace Cost_of_bootcamp_per_day
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal TotalPrice = 15500;
            int TotalDays = 65;
            decimal PerDayCost = Math.Round(TotalPrice / TotalDays, 2);
            Console.WriteLine($"Each day of bootcamp will cost ${PerDayCost}");
        }
    }
}
