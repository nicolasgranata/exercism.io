using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (!(number >= 1))
        {
            throw new ArgumentOutOfRangeException();
        }

        int result = GetSum(number);

        if (result == number)
        {
            return Classification.Perfect;
        }

        if (result > number)
        {
            return Classification.Abundant;
        }

        return Classification.Deficient;
    }

    private static int GetSum(int number)
    {
        int result = 0;

        for (var i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                result += i;
            }
        }

        return result;
    }
}
