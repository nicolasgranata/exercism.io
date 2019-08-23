using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span == 0)
        {
            return 1;
        }

        if (span < 0 || string.IsNullOrWhiteSpace(digits) || digits.Any(x => !char.IsDigit(x)) || digits.Length < span)
        {
            throw new ArgumentException();
        }

        List<long> results = new List<long>();
        List<string> substring = new List<string>();

        for (int i = 0; i < digits.Length; i++)
        {
            if (span <= digits.Length - i)
            {
                substring.Add(digits.Substring(i, span));
            }
        }

       if (substring.All(x => x.Any(j => j == '0')))
       {
           return 0;
       }

       foreach (string item in substring)
       {
           long product = 1;
           foreach (char c in item)
           {              
                product = product * (long)char.GetNumericValue(c);
                results.Add(product);
           }
       }

        return results.Max();
    }
}
