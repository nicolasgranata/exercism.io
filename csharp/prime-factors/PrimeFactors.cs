using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static int[] Factors(long number)
    {
        int divisor = 2;
        List<int> result = new List<int>();

        while(number > 1)
        {
            if (number % divisor == 0)
            {
                result.Add(divisor);
                number = number / divisor;
            }
            else
            {
                divisor++;
            }
        }

        return result.ToArray();
    }
}