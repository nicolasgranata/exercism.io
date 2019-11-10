using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private readonly string _baseWord;
    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {      
        return FindUsingForLoop(potentialMatches);
    }

    private string[] FindUsingForLoop(string[] potentialMatches)
    {
        List<string> matches = new List<string>();

        foreach (var match in potentialMatches)
        {
            if (match.Length == _baseWord.Length && !match.Contains(_baseWord))
            {
                var tempBaseWord = _baseWord;

                for (var i = 0; i < match.Length; i++)
                {
                    if (tempBaseWord.Contains(match[i]))
                    {
                        tempBaseWord = tempBaseWord.Remove(tempBaseWord.IndexOf(match[i]), 1);
                    }
                }

                if (tempBaseWord.Length == 0)
                {
                    matches.Add(match);
                }
            }
        }

        return matches.ToArray();
    }
}