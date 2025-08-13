namespace time;

using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        // Format as YYYY_MMM_DDD_HHH_MMM_SSS with 3-digit padding for all except year
        string formattedTimestamp = $"{now:yyyy}_{now.Month:D3}_{now.Day:D3}_{now.Hour:D3}_{now.Minute:D3}_{now.Second:D3}";

        Console.WriteLine(formattedTimestamp);
    }
}