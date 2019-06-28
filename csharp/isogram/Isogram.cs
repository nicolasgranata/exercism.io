using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Dictionary<char, int> temp = new Dictionary<char, int>();

        for (var i = 0; i < word.Length; i++)
        {
            if (Regex.IsMatch(word[i].ToString(), "^[a-zA-Z]"))
            {
                int value;
            
                if (temp.TryGetValue(char.ToLower(word[i]), out value))
                {
                    if (value == 1)
                    {
                        return false;
                    }
                }
                else
                {
                    temp[char.ToLower(word[i])] = 1;
                }
            }
        }

        return true;
    }
}
