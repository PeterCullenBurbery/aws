namespace time;

using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        // Get microseconds from ticks
        long microseconds = now.Ticks % TimeSpan.TicksPerSecond / 10;

        // Format: YYYY_MMM_DDD_HHH_MMM_SSS_UUUUUU
        string formattedTimestamp =
            $"{now:yyyy}_{now.Month:D3}_{now.Day:D3}_{now.Hour:D3}_{now.Minute:D3}_{now.Second:D3}_{microseconds:D6}";

        Console.WriteLine(formattedTimestamp);
    }
}