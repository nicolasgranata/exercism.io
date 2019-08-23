using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static IEnumerable<string> Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length || sliceLength <= 0 || string.IsNullOrWhiteSpace(numbers))
        {
            throw new ArgumentException();
        }

        return GetSlices(numbers, sliceLength);
    }

    private static IEnumerable<string> GetSlices(string numbers, int sliceLength)
    {
         for (var i = 0; i <= numbers.Length - sliceLength; i++)
        {
            yield return numbers.Substring(i, sliceLength);        
        }
    }
}