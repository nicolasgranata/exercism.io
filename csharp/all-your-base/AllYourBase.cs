using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase == 1 || inputBase <= 0 
                || inputDigits.Any(x => x < 0 || x >= inputBase)
                || outputBase <= 1)
        {
            throw new ArgumentException();
        }

        var result = new List<int>();

        var tempNumber = 0;

        for(int i = 0; i < inputDigits.Length; i++)
        {
            tempNumber += inputDigits[i] * Convert.ToInt32(Math.Pow(inputBase, inputDigits.Length - (i + 1)));
        }

        while(tempNumber > 0)
        {
           result.Add(tempNumber % outputBase);
           tempNumber = tempNumber / outputBase;
        }

        return result.DefaultIfEmpty().Reverse().ToArray();
    }
}