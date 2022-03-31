using System.Diagnostics;

namespace algoDat_impl_console;

public class Benchmark
{
    public static TimeSpan MeasureTimeFrom(Action toMeasure)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        toMeasure();
        stopwatch.Stop();
        return stopwatch.Elapsed;
    }

    public static string GetMeasureTimeStampFrom(Action toMeasure)
    {
        TimeSpan passed = MeasureTimeFrom(toMeasure);
        return $"{passed.Hours:00}:{passed.Minutes:00}:{passed.Seconds:00}:{passed.Milliseconds:000}";
    }
    
    
}