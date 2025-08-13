namespace time;

using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        // Each tick = 100 nanoseconds
        long nanoseconds = (now.Ticks % TimeSpan.TicksPerSecond) * 100;

        // Format: YYYY_MMM_DDD_HHH_MMM_SSS_NNNNNNNNN
        string formattedTimestamp =
            $"{now:yyyy}_{now.Month:D3}_{now.Day:D3}_{now.Hour:D3}_{now.Minute:D3}_{now.Second:D3}_{nanoseconds:D9}";

        Console.WriteLine(formattedTimestamp);
    }
}