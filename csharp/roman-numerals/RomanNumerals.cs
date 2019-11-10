using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class RomanNumeralExtension
{
    private static Dictionary<int, string> romanTable = new Dictionary<int, string>()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"}
    };

    public static string ToRoman(this int value)
    {
        var sb = new StringBuilder();

        Enumerable.Repeat(sb, 1);

        return sb.ToString();
    }
}