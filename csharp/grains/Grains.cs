﻿using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        return (ulong) Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        ulong result = 0;

        for (int i = 1; i < 65; i++)
        {
            result += Square(i);
        }

        return result;
    }
}