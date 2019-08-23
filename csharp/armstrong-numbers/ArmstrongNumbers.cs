using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        IEnumerable<int> listOfNumbers = SeparateDigits(number);

        int result = listOfNumbers.Sum(x => (int)Math.Pow(x, listOfNumbers.Count()));

        return result == number;
    }

    private static IEnumerable<int> SeparateDigits(int number)
    {
        while (number > 0)
        {
            int digit = number % 10;
            number /= 10;
            yield return digit;
        }   
    }
}