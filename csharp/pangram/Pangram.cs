using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        Dictionary<string, int> tempInput = new Dictionary<string, int>();

        for (var i = 0; i < input.Length; i++)
        {
            if (Regex.IsMatch(input[i].ToString(), "^[a-zA-Z]"))
            {
                tempInput[input[i].ToString().ToLower()] = 1;
            }           
        }

        return tempInput.Count == 26 ? true : false;
    }
}
