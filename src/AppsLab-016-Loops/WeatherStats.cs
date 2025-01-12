﻿namespace AppsLab_016_Loops;

/// <summary>
/// Class to calculate weather statistics.
/// </summary>
public class WeatherStats
{
    /// <summary>
    /// Calculate the average temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Average temperature.</returns>
    public double AverageTemperature(double[] temperatures)
    {
        double sum = 0;
        double length = temperatures.Length;

        for (int i = 0; i < temperatures.Length; i++)
        {
            sum += temperatures[i];
        }
        return sum;
    }

    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public double MaxTemperature(double[] temperatures)
    {
        double last = temperatures.Length - 1;
        double first = temperatures[0];
        for (double i = first; i <= last; i++)
        {
            Console.WriteLine(i);
        }
        return 0;
        //alebo
        double Last = temperatures.Length - 1;
        return last;
    }

    /// <summary>
    /// Find the minimum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Minimum temperature.</returns>
    public double MinTemperature(double[] temperatures)
    {
        double last = temperatures.Length - 1;
        double first = temperatures[0];
        for (double i = last; i <= first; i--)
        {
            Console.WriteLine(i);
        }
        return 0;
        //alebo
        double First = temperatures[0];
        return First;
    }
}
